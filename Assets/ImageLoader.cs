using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scripts : MonoBehaviour
{
    public RawImage Img;

    private IEnumerator Start()
    {
        WWW www = new WWW("https://i.pinimg.com/564x/4a/bc/c0/4abcc00427dbb86ee5da8270b52204f8.jpg");
        yield return www;
        Img.texture = www.texture;
    }
}
