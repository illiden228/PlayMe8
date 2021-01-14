using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LotUI : MonoBehaviour
{
    [SerializeField] private RawImage _itemImage;
    [SerializeField] private RawImage _moneyImage;
    [SerializeField] private RawImage _playerImage;
    [SerializeField] private TMP_Text _itemName;
    [SerializeField] private TMP_Text _itemCount;
    [SerializeField] private TMP_Text _itemCost;
    [SerializeField] private TMP_Text _playerName;
    [SerializeField] private TMP_Text _playerLevel;

    private Lot _lot;
    private IEnumerator _corutine;

    public void Init(Lot lot)
    {
        _lot = lot;

        _corutine = LoadImage(_lot.Player.ImageURL, _playerImage);
        StartCoroutine(_corutine);


        _itemImage.texture = _lot.Item.Image.texture;
        _itemName.text = _lot.Item.Name;
        _itemCount.text = _lot.Item.Count.ToString();
        _moneyImage.texture = _lot.Item.Moneys.Image.texture;
        _itemCost.text = _lot.Item.Moneys.Count.ToString();
        _playerName.text = _lot.Player.Name;
        _playerLevel.text = _lot.Player.Level.ToString();
    }

    private IEnumerator LoadImage(string URL, RawImage image)
    {
        WWW www = new WWW(URL);
        yield return www;
        image.texture = www.texture;
    }
}
