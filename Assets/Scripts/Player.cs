using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;


public class Player
{
    public string Name;
    public Sprite Image;
    public int Level;

    public Player(string name, int level, Sprite image)
    {
        Name = name;
        Level = level;
        Image = image;
    }
}
