using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    public int scene;
    public Image hels;
    public float helse;
   
    void Start()

    {
        
    }

    void Update()

    {
        hels.fillAmount = helse / 100;
        if (helse > 100)
        {
            helse = 100;
        }
        if (helse < 0)
        {
            helse = 0;
        }
        if (helse <= 0) 
        {
            Application.LoadLevel(scene);
        }
    }

}
