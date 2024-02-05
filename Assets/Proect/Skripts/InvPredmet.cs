using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class InvPredmet : MonoBehaviour
{
    public Text text;
    public Image image;
    public int index;
    public static event Action<int> clic;
    void Start()
    {
        transform.parent = Inventar.rid.greed;
        text.text = Inventar.rid.text;
        image.sprite = Inventar.rid.sprite;
        index = Inventar.rid.index;
    }
    public void OnClicer()
    {
        clic.Invoke(index);
        Interface.rid.Game();
        if (Inventar.rid.index == index)
        {
            Destroy(gameObject);
        }
    }
}
