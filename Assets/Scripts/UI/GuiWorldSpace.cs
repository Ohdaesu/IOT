using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuiWorldSpace : MonoBehaviour {

	private Transform transform;
	public GameObject target;

	// Use this for initialization
	void Start () {
		transform = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = Camera.main.WorldToScreenPoint(target.transform.position);
	}
}
