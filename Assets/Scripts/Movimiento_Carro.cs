using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_Carro : MonoBehaviour
{
    public int Distancia = 5;
	public int Posicion = 10;
	public int Velocidad = 3;

    // Update is called once per frame
    void Update()
    {
        transform.position = 
			new Vector3 ( transform.position.x, transform.position.y, Mathf.PingPong(Time.time*Velocidad,Distancia)-Posicion);
    }
}
