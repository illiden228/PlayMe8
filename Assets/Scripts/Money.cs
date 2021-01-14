using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewMoney", menuName = "ScriptableObjects/Money")]
public class Money : ScriptableObject
{
    public Sprite Image;
    public int Count;

    public Money(int count, Sprite image)
    {
        Count = count;
        Image = image;
    }

    public Money(Money template)
    {
        Image = template.Image;
        Count = template.Count;
    }
}
