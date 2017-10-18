using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelProgressBar : MonoBehaviour {

	public Transform LoadingBar;
	public Transform text;
	public float max;
	public string unit; 
	[SerializeField] private float amount;

	// Update is called once per frame
	void Update () {
		this.changeAmount (26);
	}

	public void changeAmount(float amount)
	{
		
		if (amount < 0) {
			amount = 0;
		} else if (amount > max)
		{
			amount = max;
		}

		text.GetComponent<Text> ().text = ((int)amount).ToString () + unit;
		LoadingBar.GetComponent<Image> ().fillAmount = amount / max;

	}
}
