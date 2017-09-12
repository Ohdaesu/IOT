using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAtCamera : MonoBehaviour {

	private Transform canvas;

	// Use this for initialization
	void Start () 
	{
		canvas = GetComponent<Transform> (); 
	}
	
	// Update is called once per frame
	void LateUpdate () {
		canvas.LookAt(Camera.main.transform.position, Vector3.up);
		canvas.Rotate (0, 180, 0);
	}
}
