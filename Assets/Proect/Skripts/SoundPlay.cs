using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour {
    public AudioSource sorse { get; set;}
    public static SoundPlayer regit {get; set;}
    private float tim;
	void Awake(){
		sorse = GetComponent<AudioSource> ();
		if (regit == null) {
			regit = this;
		} else {
			Destroy (this);
		}
	}
	void OnDestroy(){
		regit = null;
	}
    public void Play(AudioClip clip, float volume)
    {
        if (Time.timeScale > 0)
        {
            if (tim < Time.time)
            {
                tim = Time.time + 0.1f;
                sorse.PlayOneShot(clip, volume);
            }
        }
        else
        {
            sorse.PlayOneShot(clip, volume);
        }
    }
}