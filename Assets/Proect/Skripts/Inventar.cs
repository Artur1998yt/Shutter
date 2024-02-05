using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventar : MonoBehaviour
{
    public Transform greed;
    public Sprite sprite;
    public string text;
    public int index;

    public static Inventar rid { get; set; }

    void Awake()
    {
        if (rid == null)
        {
            rid = this;
        }
        else
        {
            Destroy(this);
        }
    }
    void OnDestroy()
    {
        rid = null;
    }
   
    public void OnIndex(int onIndex)
    {
        index = onIndex;
    }
    public void OnImage(Sprite onImage)
    {
        sprite = onImage;
    }
    public void OnText(string onText)
    {
        text = onText;
    }
}
