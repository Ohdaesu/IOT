using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningDoor : MonoBehaviour {

	private bool open = false;
	private Animation _animation;

	// Use this for initialization
	void Start () {
		_animation = GetComponent<Animation> ();
	}

	public void toggleMove ()
	{
		if (!open) { //close door
			_animation.Play("DoorOpen");
			open = true;
		} else { //open door
			_animation.Play("DoorClose");
			open = false;
		}
	}
}
