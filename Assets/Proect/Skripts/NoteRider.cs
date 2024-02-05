using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteRider : MonoBehaviour {
	public Text text;
	public static NoteRider regit {get; set;}

	void Awake(){
        Closed();
		if (regit == null) {
			regit = this;
		} else {
			Destroy (this);
		}
	}
	void OnDestroy(){
		regit = null;
	}
	public void Noting(string not){
        text.text = not;
	}
	public void Closed(){
        text.text = "";
    }
}
