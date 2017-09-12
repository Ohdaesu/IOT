using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonOnFan : MonoBehaviour {

	public GameObject fan;

	private Text buttonText;
	private bool isShow = false;
	private RotatorFan fanController;

	void Start() {
		buttonText =  GetComponentInChildren<Text> ();
		fanController =  fan.GetComponentInChildren<RotatorFan> ();
		}


	public void onClick () {
		if (isShow) 
		{
			buttonText.text = "ON";
			isShow  = false;
			fanController.toggleMove ();
		}else
		{
			buttonText.text = "OFF"; 
			isShow  = true;
			fanController.toggleMove ();
		}
		
	}
}
