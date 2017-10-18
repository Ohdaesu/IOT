using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GlobalVariables : MonoBehaviour {

	public bool move{get; set;}

	public String IP {get; set;}
	public int PORT {get; set;}
	public bool connect = false;

	void Start ()
	{
		move = false;
		PORT = 1883;
	}

	public void send_connectionInfo (GameObject panel){

		IP = panel.transform.Find ("IP").transform.GetComponent<InputField> ().text;
		PORT = int.Parse(panel.transform.Find ("PORT").transform.GetComponent<InputField> ().text);
		connect = true;
	
	}

	public void disconnect (){
		connect = false;
	}
}
