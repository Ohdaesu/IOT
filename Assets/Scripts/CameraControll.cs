using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class CameraControll : MonoBehaviour {

	private const float Y_ANGLE_MIN = 0.0f;
	private const float Y_ANGLE_MAX = 50.0f;

	public Transform lookAt;
	public float sensivityX = 4.0f;
	public float sensivityY = 1.0f;
	public float distance = 10.0f;

	private Transform camTransform;
	private Camera cam;


	private float currentX = 0.0f;
	private float currentY = 0.0f;


	private void Start()
	{
		camTransform = transform;
		cam = Camera.main;
	}

	private void Update()
	{
		currentX += (-1* CrossPlatformInputManager.GetAxis("Horizontal")) * sensivityX;
		currentY += CrossPlatformInputManager.GetAxis("Vertical") * sensivityY;

		currentY = Mathf.Clamp (currentY, Y_ANGLE_MIN, Y_ANGLE_MAX);

	}

	private void LateUpdate()
	{
		Vector3 dir = new Vector3 (0, 0, -distance);
		Quaternion rotation = Quaternion.Euler (currentY, currentX, 0);
		camTransform.position = lookAt.position + rotation * dir;
		camTransform.LookAt (lookAt.position);

	}

	public void setLookAt(Transform newLookAtTransform)
	{
		lookAt = newLookAtTransform;
	}
}
