using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Input : MonoBehaviour {

	private Muwer muwer;
	// Use this for initialization
	void Start () {
		muwer = GetComponent<Muwer> ();
	}
	

	void Update () {
		muwer.muve = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));

	}
}
