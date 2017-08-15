using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WallsButton : MonoBehaviour  {

	public GameObject casa;
	private bool show = false;

	public void onClickWalls ()
	{
		if (show) 
		{
			show = false;
			casa.SetActive (false);
		} else 
		{
			show = true;
			casa.SetActive (true);

		}
	}
}
