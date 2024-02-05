using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{
    public Light li;
    public MeshRenderer render;
    public Material mat;
    public void Click(bool on)
    {
        li.enabled = on;
        if (on)
        {
            render.material = mat;
        }
    }
}
