using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEnableMove : MonoBehaviour {

	private Text buttonText;
	public GameObject globalObject;

	private GlobalVariables globalVariables;

	void Start()
	{
		buttonText = GetComponentInChildren<Text> ();
		globalVariables  = globalObject.GetComponent<GlobalVariables> ();
	}

	public void onClick ()
	{
		bool move = globalVariables.move;
		if (move) 
		{
			buttonText.text = "NOT MOVE";
			globalVariables.move = false;
		} else 
		{
			buttonText.text = "MOVE";
			globalVariables.move = true;
		}
	}
}
