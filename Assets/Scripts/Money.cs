using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money
{
    public Sprite Image;
    public int Count;

    public Money(int count, Sprite image)
    {
        Count = count;
        Image = image;
    }
}
