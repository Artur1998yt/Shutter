using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public HP hp;
    
    void Start()

    {
        
    }

    void OnTriggerEnter(Collider other)

    {
            if (other.gameObject.tag == "Player")
            {
                if (hp.helse < 100)
                {
                    hp.helse += 33.3f;
                    Destroy(gameObject);
                }
                else
                {
                    
                        
                }
            }
    }
   
}
