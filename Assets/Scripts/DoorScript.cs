using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DoorScript : MonoBehaviour, IPointerClickHandler {
	public float doorOpenAngle = 90.0f;
	public float doorCloseAngle = 0.0f;
	public float doorAnimSpeed = 2.0f;
	private Quaternion doorOpen = Quaternion.identity;
	private Quaternion doorClose = Quaternion.identity;
	public bool doorStatus = false; //false is close, true is open
	private bool doorGo = false; //for Coroutine, when start only one
	void Start() {
		doorStatus = false; //door is open, maybe change
		//Initialization your quaternions
		doorOpen = Quaternion.Euler (0, doorOpenAngle, 0);
		doorClose = Quaternion.Euler (0, doorCloseAngle, 0);
	}

	public IEnumerator moveDoor(Quaternion dest) {
		doorGo = true;
		if (doorStatus)
		{
			dest = doorOpen;
		}
		else dest = doorClose;

		//Check if close/open, if angle less 4 degree, or use another value more 0
		while (Quaternion.Angle(transform.localRotation, dest) > 4.0f) {
			transform.localRotation = Quaternion.Slerp(transform.localRotation, dest, Time.deltaTime * doorAnimSpeed);
			//UPDATE 1: add yield
			yield return null;
		}
		//Change door status
		doorStatus = !doorStatus;
		doorGo = false;
		//UPDATE 1: add yield
		yield return null;
	}
	public void OnPointerClick (PointerEventData evd)
	{
		if (doorStatus) { //close door
			StartCoroutine(this.moveDoor(doorClose));
		} else { //open door
			StartCoroutine(this.moveDoor(doorOpen));
		}
	}
}
