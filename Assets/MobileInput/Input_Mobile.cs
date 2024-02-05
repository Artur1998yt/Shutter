using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InstantGamesBridge;

public class Input_Mobile : MonoBehaviour
{
	private Vector2 lookInputPrev = Vector2.zero;

	void Awake()
	{
		if (Bridge.device.type == InstantGamesBridge.Modules.Device.DeviceType.Desktop)
		{
			Destroy(gameObject);
			return;
		}
	}

	void OnEnable()
	{
		if (Muwer.rid)
		{
			Muwer.rid.rute = Vector2.zero;
			lookInputPrev = Muwer.rid.rute;
		}

	}

	void Start()
	{
		Muwer.rid.rute = Vector2.zero;
		lookInputPrev = Muwer.rid.rute;
		StartCoroutine(StopEnum());
	}


	public void MovementInput(Vector2 temp)
	{
		if (Muwer.rid)
		{
            Muwer.rid.muve = new Vector3(temp.x, 0, temp.y);
		}
	}

	public void RotationInput(Vector2 temp)
	{
		Muwer.rid.rute = temp;
	}

	private IEnumerator StopEnum()
	{

		while (true)
		{
			lookInputPrev = Muwer.rid.rute;
			yield return new WaitForSeconds(0.01f);
			if (lookInputPrev == Muwer.rid.rute)
			{
				lookInputPrev = Vector2.zero;
				Muwer.rid.rute = Vector2.zero;
			}
		}
	}
}
