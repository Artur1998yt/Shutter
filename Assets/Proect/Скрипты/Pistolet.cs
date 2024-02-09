using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistolet : MonoBehaviour
{
    public Shut shut;
    public GameObject patrony;
    
    void Start()

    {
        
    }

    void OnTriggerEnter(Collider other)

    {
        if(other.gameObject.tag == "Player")
        {
            shut.enabled = true;
            patrony.SetActive(true);
            Destroy(gameObject);
        }
    }

}
