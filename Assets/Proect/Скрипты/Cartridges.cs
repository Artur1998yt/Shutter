 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cartridges : MonoBehaviour



{
    public float dist;
    public Transform player;
    public Transform cartridges;
    public Shut shut;
    public int patronyLoot;
    public AudioSource sorse;
    public AudioClip clip;
    public AudioClip clip1;

    private int number;

    void Start()

    {
        
    }

    void Update()

    {
        dist = Vector3.Distance (player.position , cartridges.position);
        if (dist <= 1)
        {
               number = shut.patronyMax - shut.patrony;
               if (shut.patrony >= 5)
               {
                   sorse.PlayOneShot(clip);
               }
               else
               {
                   sorse.PlayOneShot(clip1);
               }
               if (number < patronyLoot)
               {
                   shut.patrony += number;
                   patronyLoot -= number;
               }
               else
               {
                   shut.patrony += patronyLoot;
                   Destroy (cartridges.gameObject);
               }
        }
    }

}
