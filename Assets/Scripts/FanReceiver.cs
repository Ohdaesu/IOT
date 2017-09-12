using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FanReceiver : AbstractReceiver, IPointerClickHandler   {

	private mqttTest mqtt;

	public GameObject ventilador;

	public void Start ()
	{
		mqtt = GetComponent<mqttTest> ();
	}
	public override void receiveHandler (string msg)
	{
		if (msg == "toggle") 
		{
			ventilador.GetComponent<RotatorFan> ().toggleMove ();
		}
	}

	public void OnPointerClick (PointerEventData evd)
	{
		mqtt.pubMSG (0);
		ventilador.GetComponent<RotatorFan> ().toggleMove ();
	}
}
