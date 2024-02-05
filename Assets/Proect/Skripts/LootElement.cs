using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootElement : MonoBehaviour {
	public Transform inventar {get; set;}
	public static LootElement regit {get; set;}

	void Awake(){
		inventar = transform;
		if (regit == null) {
			regit = this;
		} else {
			Destroy (this);
		}
	}
	void OnDestroy(){
		regit = null;
	}
}
