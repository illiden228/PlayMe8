using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Lot
{
    public Item Item;
    public Player Player;

    public Lot(Item item, Player player)
    {
        Item = item;
        Player = player;
    }
}
