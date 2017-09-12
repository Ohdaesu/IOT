using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIDisplay : MonoBehaviour, IPointerClickHandler {

	public GameObject canvas;
	private bool isShow = false;

	// Use this for initialization
	void Start () {
		canvas.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnPointerClick (PointerEventData evd)
	{
		if (isShow) 
		{
			canvas.SetActive (false); 
			isShow  = false;
		}else
		{
			canvas.SetActive (true); 
			isShow  = true;
		}
	}
}
