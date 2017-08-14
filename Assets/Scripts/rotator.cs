using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour {
	public int speed;
	private Vector3 rotation;

	void Start () {
		rotation = new Vector3 (0,speed,0);
	}
	// Update is called once per frame
	void Update () {
		transform.Rotate (rotation * Time.deltaTime);
	}
}
