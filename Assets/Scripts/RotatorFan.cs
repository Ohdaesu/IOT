using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorFan : MonoBehaviour {
	public int speed;
	private Vector3 rotation;
	private bool move = false;

	void Start () {
		rotation = new Vector3 (0,speed,0);
	}
	// Update is called once per frame
	void Update () {
		if (move) 
		{
			transform.Rotate (rotation * Time.deltaTime);
		}
	}

	public void toggleMove ()
	{
		move = !move;
	}
}
