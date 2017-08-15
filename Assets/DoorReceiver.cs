using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorReceiver : AbstractReceiver {

	public GameObject door;

	public override void receiveHandler (string msg)
	{
		if(msg == "toggle")
			door.GetComponent<OpeningDoor> ().toggleMove ();
	}
}
