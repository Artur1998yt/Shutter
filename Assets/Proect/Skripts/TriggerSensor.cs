using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class TriggerSensor : MonoBehaviour {
	
	private Transform cam;
    public UnityEvent touch, resed;
    public int imgIndex;
    public float spector = 20;
    private bool activ;
	private float vzglyad;

	void Start(){
		cam = Camera.main.transform;
	}
	void Update(){
		if (activ) {
			var looker = transform.position - cam.position;
			vzglyad = Quaternion.Angle (cam.rotation, Quaternion.LookRotation(looker));
			if (vzglyad <= spector) {
				activ = false;
                touch.Invoke();
                IMG.rid.ImgOn(0);
            }
		} 
	}
	void OnTriggerEnter(Collider oser){
		if (oser.tag == "Player") {
			activ = true;
            IMG.rid.ImgOn(imgIndex);
		}
	}
	void OnTriggerExit(Collider oser){
		if (oser.tag == "Player") {
			activ = false;
            resed.Invoke();
            IMG.rid.ImgOn(0);
        }
	}
}
