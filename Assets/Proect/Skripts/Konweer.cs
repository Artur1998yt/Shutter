using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Konweer : MonoBehaviour
{
    public MeshRenderer render;
    public Vector2 nap;
    void Update()
    {
        render.material.mainTextureOffset += nap * Time.deltaTime;
    }
    void OnTriggerEnter(Collider oser)
    {
        if (oser.tag == "Player")
        {
            Muwer.rid.controller.Move(new Vector3(nap.x, 0, nap.y) * Time.deltaTime);
        }
    }
    void OnTriggerExit(Collider oser)
    {
        if (oser.tag == "Player")
        {
            Muwer.rid.muvePlatform = new Vector3(0, 0, 0);
        }
    }
}
