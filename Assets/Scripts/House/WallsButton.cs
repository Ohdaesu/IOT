using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class WallsButton : MonoBehaviour  {

	public GameObject [] casas;
	private bool show = true;

	public void Start()
	{
		Button btn = GetComponent<Button>();
		btn.onClick.AddListener (onClickWalls);

	}

	public void onClickWalls ()
	{
		if (show) 
		{
			show = false;
			foreach (GameObject casa in casas){
				casa.SetActive (false);
			}
		} else 
		{
			show = true;
			foreach (GameObject casa in casas){
				casa.SetActive (true);
			}
		}
	}
}