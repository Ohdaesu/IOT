using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_setRoom : MonoBehaviour {

	public Transform myCamera;
	public GameObject panel;

	private GameObject infoButton;


	//public Button yourButton;

	// Use this for initialization
	void Start () {
		

		infoButton = GameObject.Find ("infoButton");


		//Button btn = yourButton.GetComponent<Button>();
		Button btn = GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void TaskOnClick()
	{
		//Debug.Log("You have clicked the button!");

		infoButton.GetComponent<UI_setInfoPanel> ().changePanel (panel);
		Camera.main.GetComponent<CameraControll> ().setLookAt (myCamera);
	}
}
