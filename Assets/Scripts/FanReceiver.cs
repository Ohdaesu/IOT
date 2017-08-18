using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FanReceiver : AbstractReceiver, IPointerClickHandler   {

	public GameObject ventilador;

	public override void receiveHandler (string msg)
	{
		if(msg == "toggle")
			ventilador.GetComponent<RotatorFan> ().toggleMove ();
	}

	public void OnPointerClick (PointerEventData evd)
	{
		ventilador.GetComponent<RotatorFan> ().toggleMove ();
	}
}
