using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public Sprite Image;    
    public Money Moneys;
    public string Name;
    public int Count;

    public Item(int count, string name, Money moneys, Sprite image)
    {
        Count = count;
        Name = name;
        Moneys = moneys;
        Image = image;
    }
}
