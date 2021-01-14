using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewItem", menuName = "ScriptableObjects/Item")]
public class Item : ScriptableObject
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

    public Item(Item template)
    {
        Image = template.Image;
        Moneys = new Money(template.Moneys);
        Name = template.Name;
        Count = template.Count;
    }
}
