using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InstantGamesBridge;

public class NoteSkript : MonoBehaviour {
    [SerializeField] private Language language;
    public AudioClip clip;
    public void Rider()
    {
        SoundPlayer.regit.Play(clip,1);
        if (Bridge.platform.language == "ru")
        {
            NoteRider.regit.Noting(language.ru);
        }
        else
        {
            NoteRider.regit.Noting(language.en);
        }
    }
}
