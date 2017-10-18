using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class masterReceiver : AbstractReceiver {

	public override void receiveHandler (string msg)
	{
		Debug.Log ("Master Receiver");
	}

}