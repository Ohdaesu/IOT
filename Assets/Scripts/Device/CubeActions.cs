using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CubeActions : MonoBehaviour, IPointerClickHandler {

	private Transform cubeTransform;

	// Use this for initialization
	void Start () {
		cubeTransform = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnPointerClick (PointerEventData evd)
	{
		Camera.main.GetComponent<CameraControll> ().setLookAt (cubeTransform);
	}
}
