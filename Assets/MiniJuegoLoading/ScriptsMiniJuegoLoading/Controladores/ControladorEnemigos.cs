using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorEnemigos : MonoBehaviour 
{
	//Referencia a los enemigos que quieres generar
	public GameObject enemigo1;

	//Tiempo a pasar para generar un enemigo nuevo
	public float generarEnemigoCada = 2.0f;

	//tiempo que ha pasado
	float tiempoTranscurrido = 0;


	// Update is called once per frame
	void Update () 
	{
		//Suma el tiempo actual
		tiempoTranscurrido += Time.deltaTime;

		//cuando tiempoTranscurrido sea igual o mayor que generarEnemigoCada, genera un enemigo y reinicia el contador
		//para que pueda seguir contando y generar el siguiente enemigo.
		if(tiempoTranscurrido >= generarEnemigoCada)
		{
			GenerarEnemigo(enemigo1);
			tiempoTranscurrido = 0;
		}

	}

	//Metodo encargado de generar enemigos, solo crea una instancia de el tipo de enemigo deseado
	public void GenerarEnemigo(GameObject tipo)
	{
		if(tipo == null)
		{
			//Si no especificas un tipo de enemigo, no pasara nada
		}

		Instantiate(tipo, transform);
	}
}
