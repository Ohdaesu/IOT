using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DoorReceiver : AbstractReceiver, IPointerClickHandler {

	public GameObject door;

	public override void receiveHandler (string msg)
	{
		if(msg == "toggle")
			door.GetComponent<OpeningDoor> ().toggleMove ();
	}
	public void OnPointerClick (PointerEventData evd)
	{
		door.GetComponent<OpeningDoor> ().toggleMove ();
	}
}
