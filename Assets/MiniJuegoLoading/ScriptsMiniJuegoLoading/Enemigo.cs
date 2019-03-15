using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour 
{
	float velocidad = 5.0f;

	void Update () 
	{
		Mover();
	}

	//Añade velocidad cada frame para que avance
	void Mover()
	{
		GetComponent<Rigidbody2D>().velocity = new Vector2(-velocidad, GetComponent<Rigidbody2D>().velocity.y);
	}

	//Cuando el enemigo sale de la pantalla, este se destrulle para ahorrar recursos
	void OnBecameInvisible() 
	{
        Destroy(gameObject);
    }
}
