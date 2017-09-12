using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{

	public GameObject globalObject;
	public float speed = 1f; 

	private GlobalVariables globalVariables;

	private Vector3     distance;
	private bool        canDrag;
	private Rigidbody   rb;
	private BoxCollider bc;
	private Renderer    rend;
	private Transform transform;

	void Start()
	{
		transform  = GetComponent<Transform> ();
		globalVariables  = globalObject.GetComponent<GlobalVariables> ();
		rb = GetComponent<Rigidbody> (); 
		rb.freezeRotation = true;
	}

	void Update()
	{
		if ( globalVariables.move)
		{
			if (canDrag)
			{
				Vector3 distance_to_screen = Camera.main.WorldToScreenPoint (transform.position);
				Vector3 pos_move           = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, distance_to_screen.z));
				// transform.position         = new Vector3 (pos_move.x - distance.x, transform.position.y, pos_move.z - distance.z);
				Vector3 movement  = new Vector3 (pos_move.x - transform.position.x, 0, pos_move.z - transform.position.z);
				rb.AddForce (movement * speed,ForceMode.Force);
			}
		}
	}

	void OnMouseDown()
	{
		canDrag      = true;
		distance     = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,Camera.main.WorldToScreenPoint(transform.position).z)) - transform.position;
	}

	void OnMouseUp()
	{
		canDrag      = false;
	}



}