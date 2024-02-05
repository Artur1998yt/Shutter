using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IMG : MonoBehaviour
{
    public Image img;
    public Sprite[] sprites;

    public static IMG rid { get; set; }

    void Awake()
    {
        ImgOn(0);
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
    public void ImgOn(int num)
    {
        img.sprite = sprites[num];

    }
}
