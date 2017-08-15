using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FanReceiver : AbstractReceiver  {

	public GameObject ventilador;

	public override void receiveHandler (string msg)
	{
		if(msg == "toggle")
			ventilador.GetComponent<RotatorFan> ().toggleMove ();
	}
}
