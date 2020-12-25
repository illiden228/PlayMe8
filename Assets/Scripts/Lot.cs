using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lot : MonoBehaviour
{
    public Item Item;
    public Player Player;

    public Lot(Item item, Player player)
    {
        Item = item;
        Player = player;
    }
}
