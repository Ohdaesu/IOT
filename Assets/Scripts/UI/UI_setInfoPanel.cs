using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_setInfoPanel : MonoBehaviour {

	public GameObject scheduler;
	public GameObject panel;

	// Use this for initialization
	void Start () {
		Button btn = GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
		
	}

	void TaskOnClick()
	{
		scheduler.GetComponent<UI_Scheduler> ().changeActive (panel);
	}

	public void changePanel(GameObject panel){
	
		this.panel = panel;
	
	}
}