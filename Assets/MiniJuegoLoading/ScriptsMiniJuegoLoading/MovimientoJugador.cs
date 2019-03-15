using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovimientoJugador : MonoBehaviour 
{
	public float fuerzaSalto = 2.0f;
    private int Score=0;
	bool puedeSaltar = false;
	bool gameOver = false;

    public Text score;


	void Update () 
	{
		if(!gameOver)
		{
			Saltar();
		}

        score.text = "Score: " + Score;

    }

	//Metodo que checa si es posible saltar
	public void Saltar()
	{
		//checa si presionas espacio y puedes saltar, te deja saltar
		if(Input.GetKeyDown("space") && puedeSaltar)
		{
			transform.position = new Vector2(transform.position.x, transform.position.y + fuerzaSalto);
            Score++;
        }
	}

	//Mientras estes en el piso, puedes saltar
	void OnCollisionStay2D(Collision2D other)
	{
		//Comprueba que si con lo que esta chocando (other) tiene la etiqueta de piso, activa el salto
		if(other.gameObject.tag =="Piso")
		{
			puedeSaltar = true;
		}
	}

	//Cuando saltes y despegues del piso, ya no puedes saltar
	void OnCollisionExit2D(Collision2D other)
	{
		if(other.gameObject.tag =="Piso")
		{
			puedeSaltar = false;
		}
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.tag =="Enemigo")
		{
			Time.timeScale = 0;
			gameOver = true;
		}
	}

   
}
