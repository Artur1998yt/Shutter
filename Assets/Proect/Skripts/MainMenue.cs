using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenue : MonoBehaviour {
	public GameObject[] podmenues;
	public string startLavelName;
	public string lavelName;
	public int num = 3;

	void Start () {
		Time.timeScale = 1;
	}
	void Update(){
		for (int i = 0; i < podmenues.Length; i++) {
			if (i == num) {
				podmenues [i].SetActive (true);
			} else {
				podmenues [i].SetActive (false);
			}
		}
	}
	public void Starter(){
		num = 0;
	}
	public void Loade(){
		num = 1;
	}
	public void Quiter(){
		num = 2;
	}
	public void Reseter(){
		num = 3;
	}

	public void Setinger(){
		num = 4;
	}
	public void Helper(){
		num = 5;
	}

	public void LateGamee () {
		SceneManager.LoadScene (lavelName);
	}
	public void StartGamee () {
		SceneManager.LoadScene (startLavelName);
	}
	public void QuitGamee () {
		Application.Quit ();
	}
}
