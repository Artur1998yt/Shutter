using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Input : MonoBehaviour {

	void Update () {
        if (Muwer.rid.muve.magnitude > 0.01f)
        {
            Time.timeScale = 1.0f;
        }
        else
        {
            Time.timeScale = 0.1f;
        }
		Muwer.rid.muve = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
        Muwer.rid.rute = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Interface.rid.Pause();
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shuter.rid.Shut();
        }
    }
}
