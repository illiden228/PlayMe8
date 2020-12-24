using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stock : MonoBehaviour
{
    [SerializeField] private CanvasGroup _stockPanel;
    [SerializeField] private BlurEnabler _blur;
    [SerializeField] private Button _openButton;
    [SerializeField] private Button _closeButton;

    private void Start()
    {
        CloseStock();
    }

    private void OnEnable()
    {
        _openButton.onClick.AddListener(OpenStock);
        _closeButton.onClick.AddListener(CloseStock);
    }

    private void OnDisable()
    {
        _openButton.onClick.RemoveListener(OpenStock);
        _closeButton.onClick.RemoveListener(CloseStock);
    }

    private void OpenStock()
    {
        _stockPanel.alpha = 1;
        _stockPanel.interactable = true;
        _stockPanel.blocksRaycasts = true;
        _blur.Activate();
    }

    private void CloseStock()
    {
        _stockPanel.alpha = 0;
        _stockPanel.interactable = false;
        _stockPanel.blocksRaycasts = false;
        _blur.Deactivate();
    }
}
