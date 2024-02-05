using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System;
public class Passworder : MonoBehaviour {
	public int password;
	public int maxKeys = 3;
	public Text displayText;
    public static event Action<int> passwordIn;
    public void Deselect(){
        password = 0;
		displayText.text = "";
	}
    public void Select()
    {
        Interface.rid.Game();
        passwordIn.Invoke(password);
        Deselect();
    }
	public void Click(int i){
        if (displayText.text.Length < maxKeys)
        {
            password = 10 * password + i;
            displayText.text = "" + password;
        }
        else
        {
            Select();
        }
	}
}