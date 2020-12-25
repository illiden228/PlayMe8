using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServerEmulator : MonoBehaviour
{
    [SerializeField] private Sprite[] _itemImages;
    [SerializeField] private Sprite[] _playerImages;
    [SerializeField] private Sprite[] _moneyImages;

    public List<Lot> CreateLots()
    {
        var newMoney1 = new Money(50, _moneyImages[0]);
        var newMoney2 = new Money(50, _moneyImages[1]);
        var item = new Item(45, "Какой-то предмет", newMoney1, _itemImages[Random.Range(0, _itemImages.Length)]);
        var item2 = new Item(56, "Какой-то предмет", newMoney2, _itemImages[Random.Range(0, _itemImages.Length)]);
        var player = new Player("Енотик", 9, _playerImages[0]);
        var player2 = new Player("Енотик", 86, _playerImages[1]);
        var lot = new Lot(item, player);
        var lot2 = new Lot(item2, player2);
        var lot3 = new Lot(item, player);
        var lot4 = new Lot(item2, player);
        var lot5 = new Lot(item, player2);
        var lot6 = new Lot(item2, player);
        var lot7 = new Lot(item, player);
        var lot8 = new Lot(item, player);
        var lot9 = new Lot(item2, player);
        var lot10 = new Lot(item, player2);
        var lot11 = new Lot(item, player2);
        var lot12 = new Lot(item, player2);
        var lot13 = new Lot(item, player2);
        var lot14 = new Lot(item, player2);
        var lot15 = new Lot(item, player2);
        var lot16 = new Lot(item, player2);

        return new List<Lot>() { lot, lot2, lot3, lot4, lot5, lot6, lot7, lot8, lot9, lot10, lot11, lot12,lot13,lot14,lot15,lot16,
            new Lot(item, player2),
            new Lot(item, player2),
            new Lot(item, player2),
            new Lot(item, player2),
            new Lot(item, player2),
            new Lot(item, player2),
            new Lot(item, player2),
            new Lot(item, player2),
            new Lot(item, player2),
            new Lot(item, player2),
            new Lot(item, player2),
            new Lot(item, player2),
            new Lot(item, player2),
            new Lot(item, player2),
            new Lot(item, player2),
            new Lot(item, player2)
        };
    }
}
