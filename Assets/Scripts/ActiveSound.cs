using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveSound : MonoBehaviour
{
    public AudioSource _AudioMoneda;
    public AudioSource _AudioObjeto;
    public AudioSource _AudioPublico;
    

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Moneda" || other.gameObject.name == "Moneda (1)" || other.gameObject.name == "Moneda (2)" || other.gameObject.name == "Moneda (3)") _AudioMoneda.Play();
        if (other.gameObject.name == "ActivadorPublico") _AudioPublico.Play();
    }

    void Update()
    { if (Input.GetKeyDown(KeyCode.M) || Input.GetKeyDown(KeyCode.E)) _AudioObjeto.Play(); }
}
