using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class StockUI : MonoBehaviour
{
    [SerializeField] private CanvasGroup _stockPanel;
    [SerializeField] private BlurEnabler _blur;
    [SerializeField] private ScrollRect _scrollView;
    [SerializeField] private LotScroller _scroller;
    [SerializeField] private GameObject _lotPrefab;
    [SerializeField] private Button _openButton;
    [SerializeField] private Button _closeButton;
    [SerializeField] private Button _nextButton;
    [SerializeField] private Button _previousButton;

    [SerializeField] private ServerEmulator _server;

    private RectTransform _scrollViewport;
    private GridLayoutGroup _scrollContent;
    private List<LotUI> _lotsUI = new List<LotUI>();

    private void Start()
    {
        _scrollViewport = _scrollView.viewport;
        _scrollContent = _scrollView.content.GetComponent<GridLayoutGroup>();

        ResizeSlot();
        RemoveLots();
        CloseStock();
    }

    private void OnEnable()
    {
        _openButton.onClick.AddListener(OpenStock);
        _closeButton.onClick.AddListener(CloseStock);
        _nextButton.onClick.AddListener(OnNextButtonClick);
        _previousButton.onClick.AddListener(OnPreviousButtonClick);
    }

    private void OnDisable()
    {
        _openButton.onClick.RemoveListener(OpenStock);
        _closeButton.onClick.RemoveListener(CloseStock);
        _nextButton.onClick.RemoveListener(OnNextButtonClick);
        _previousButton.onClick.RemoveListener(OnPreviousButtonClick);
    }

    private void OpenStock()
    {
        _stockPanel.alpha = 1;
        _stockPanel.interactable = true;
        _stockPanel.blocksRaycasts = true;
        _blur.Activate();
        GetLots();
        _scroller.SetColumns(Mathf.Ceil(_lotsUI.Count / 3f));
    }

    private void CloseStock()
    {
        _stockPanel.alpha = 0;
        _stockPanel.interactable = false;
        _stockPanel.blocksRaycasts = false;
        _blur.Deactivate();
        RemoveLots();
    }

    private void ResizeSlot()
    {
        Vector2 newCellSize = new Vector2(_scrollViewport.rect.width / 2 - 3, _scrollViewport.rect.height / 3);
        _scrollContent.cellSize = newCellSize;
    }

    private void OnNextButtonClick()
    {
        _scroller.ScrollForward();
    }

    private void OnPreviousButtonClick()
    {
        _scroller.ScrollBack();
    }

    private void RemoveLots()
    {
        var lots = _lotsUI;

        if (_lotsUI.Count == 0)
            lots = GetComponentsInChildren<LotUI>().ToList();

        foreach (var lot in lots)
        {
            Destroy(lot.gameObject);
        }

        _lotsUI = new List<LotUI>();
    }

    private void GetLots()
    {
        List<Lot> lots = JsonUtility.FromJson<StockData>(_server.GetLots()).Lots.ToList();
        foreach (var lot in lots)
        {
            var newLot = Instantiate(_lotPrefab, _scrollContent.transform).GetComponent<LotUI>();
            newLot.Init(lot);
            _lotsUI.Add(newLot);
        }
    }
}
