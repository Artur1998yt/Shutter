using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shuter : MonoBehaviour
{
    public AudioClip shut, relod;
    public Animator anim;
    public Transform bolter;
    public GameObject bolt;
    private bool gun = true;
    public static Shuter rid { get; set; }
    private Vector3 pos;
    void Awake()
    {
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
    public void Shut()
    {
        if (gun)
        {
            anim.SetBool("Shut", true);
            gun = false;
        }
    }
    public void Gun()
    {
        SoundPlayer.regit.Play(shut, 1);
        bolter.gameObject.SetActive(false);
        Instantiate(bolt, bolter.position, bolter.rotation);
    }
    public void Reload()
    {
        anim.SetBool("Shut", false);
        SoundPlayer.regit.Play(relod, 1);

    }
    public void Dan()
    {
        bolter.gameObject.SetActive(true);
        gun = true;
    }
    private void Update()
    {
        anim.SetFloat("Speed", (1.1f - Time.timeScale)*10);
    }
}
