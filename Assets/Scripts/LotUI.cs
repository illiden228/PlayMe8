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

    private Item _item;
    private Player _player;
    private Money _money;
}
