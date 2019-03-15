using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorJuego : MonoBehaviour 
{
	public Text scoreTxt;

	float score = 0;
	
	// Update is called once per frame
	void Update () 
	{
		scoreTxt.text = ""+ score;
	}

	//Si logras saltar al enemigo, suma 1 al score
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == "Enemigo")
		{
			score ++;
		}
	}
}
