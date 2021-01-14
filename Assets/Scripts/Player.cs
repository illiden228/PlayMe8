using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Player
{
    public string Name;
    public string ImageURL;
    public int Level;

    public Player(string name, int level, string image)
    {
        Name = name;
        Level = level;
        ImageURL = image;
    }
}
