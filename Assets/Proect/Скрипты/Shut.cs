using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shut : MonoBehaviour
{
    public int patrony;
    public int patronyMax;
    public Text text;
    public AudioSource sorse;
    public AudioClip clip;
    public AudioClip clip1;

    void Shuting()

    {
        RaycastHit hit;
        Ray ray = new Ray(Camera.main.transform.position , Camera.main.transform.forward);
        if(Physics.Raycast(ray , out hit))
        {
            if(hit.collider.tag == "Enemy")
            {

            }
        }
    }

    void Start()

    {
        
    }

    void Update()

    {
        text.text = "" + patrony;
        if(Input.GetKeyDown(KeyCode.Mouse1))
        {
            if(patrony > 0)
            {
                patrony -= 1;
                Shuting();
                sorse.PlayOneShot(clip);
            }
            else
            {
                sorse.PlayOneShot(clip1);
            }
        } 
    }

}
