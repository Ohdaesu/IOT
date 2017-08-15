using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OpeningDoor : MonoBehaviour, IPointerClickHandler {

	private bool open = false;
	private Animation _animation;

	// Use this for initialization
	void Start () {
		_animation = GetComponent<Animation> ();
	}

	public void OnPointerClick (PointerEventData evd)
	{
		toggleMove ();
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
