using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public HP hp;
    public AudioSource sorce;
    public AudioClip clip;
    
    void Start()

    {
        
    }

    void OnTriggerEnter(Collider other)

    {
        if(other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            hp.helse += 20;
            sorce.PlayOneShot(clip);
        }
    } 
        
}
