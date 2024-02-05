using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InstantGamesBridge;
using UnityEngine.Events;

public class DorOpener : MonoBehaviour {
    public int index;
    public TriggerSensor sensor;
    public AudioClip open;
    [SerializeField] private Language opened, closed;
    public bool locked;
    public Animator anim;
    public UnityEvent forOpen;
    public void OnEventer()
    {
        Inventar.rid.index = index;
        InvPredmet.clic += UnLocked;
        Passworder.passwordIn += UnLocked;
    }
    public void OffEventer()
    {
        InvPredmet.clic -= UnLocked;
        Passworder.passwordIn -= UnLocked;
    }
    public void PlOpen()
    {
        SoundPlayer.regit.Play(open,1);
        forOpen.Invoke();
    }
    public void UnLocked(int indexer)
    {
        if (index == indexer)
        {
            anim.SetFloat("Speed", 0.8f);
        }
        else
        {
            if (Bridge.platform.language == "ru")
            {
                SubTitres.rid.MaSage(closed.ru);
            }
            else
            {
                SubTitres.rid.MaSage(closed.en);
            }
        }
    }
    public void OpenDoor()
    {
        if (!locked)
        {
            anim.SetFloat("Speed", 0.8f);
            SoundPlayer.regit.Play(open,1);
            if (Bridge.platform.language == "ru")
            {
                SubTitres.rid.MaSage(opened.ru);
            }
            else
            {
                SubTitres.rid.MaSage(opened.en);
            }
        }
        else
        {
            Interface.rid.Inventar();
        }
    }
    public void Dan()
    {
        if (!locked)
        {
            if (Bridge.platform.language == "ru")
            {
                SubTitres.rid.MaSage(opened.ru);
            }
            else
            {
                SubTitres.rid.MaSage(opened.en);
            }
        }
        
        anim.SetFloat("Speed", 0.0f);
        Destroy(this);
        Passworder.passwordIn -= UnLocked;
        forOpen.Invoke();
        Destroy(sensor);
    }
}
