using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubTitres : MonoBehaviour {
	public Text masage;
	public static SubTitres rid {get; set;}
	private float timer;

	void Awake(){
		if (rid == null) {
			rid = this;
		} else {
			Destroy (this);
		}
	}
	void OnDestroy(){
		rid = null;
	}
    public void Clear()
    {
        masage.text = "";
    }
    public void MaSage(string mas)
    {
        timer = Time.time + mas.Length/3;
        masage.text = mas;
    }
    private void Update()
    {
        if (Time.time > timer)
        {
            Clear();
        }
    }
}
