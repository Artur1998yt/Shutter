using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PssPanel : MonoBehaviour {
	public AudioClip ok, coll;
	public string masage, okay;
	public DorOpener door;
	public UnityEvent activate, deactivate;
	public int password;
	private TriggerSensor sensor;
	public int not{ get; set; }
	public bool activ{ get; set; }
	public static PssPanel rec {get; set;}
	private float timer;

	void Awake(){
		if (rec == null) {
			rec = this;
		} else {
			Destroy (this);
		}
	}
	void OnDestroy(){
		rec = null;
	}
	void Start () {
		sensor = GetComponent<TriggerSensor> ();
		door.locked = true;
	}

	void Update () {
		
	}
}
