using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using uPLibrary.Networking.M2Mqtt;


public class MQTTisConnected : MonoBehaviour {

	private Text label;
	public GameObject client;

	void Start(){
		label = GetComponent<Text> ();
	
	}

	void Update (){
		bool state = client.GetComponent<mqttTest>().IsConnected();
		if(state)
			label.text = "Connected";
		else
			label.text = "Disconnected";
	}
}
