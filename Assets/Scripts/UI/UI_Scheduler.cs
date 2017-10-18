using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Scheduler : MonoBehaviour {

	private GameObject active;
	//private GameObject button;

	public void changeActive (GameObject newActive){
		bool state = true;


		if (active != null && active.name != newActive.name)
			active.SetActive (false);
		else if (active != null) {
			state = ! active.activeSelf;
		}	
		active = newActive;
		active.SetActive(state);
	}
		
}
