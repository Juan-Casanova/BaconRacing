using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_GloboCerdo : MonoBehaviour
{

    public float distancia = 0;
    public float posicion = 0;

    void Update()
    {
         

        transform.position =
            new Vector3(transform.position.x, Mathf.PingPong(Time.time * 3, distancia) - posicion, transform.position.z);
    }
}
