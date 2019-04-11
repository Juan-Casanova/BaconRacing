using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveSound : MonoBehaviour
{
    public AudioSource _AudioMoneda;
    public AudioSource _AudioObjeto;

    void OnTriggerEnter(Collider other)
    { if (other.gameObject.name == "Moneda") _AudioMoneda.Play(); }

    void Update()
    { if (Input.GetKeyDown(KeyCode.M) && Input.GetKeyDown(KeyCode.E)) _AudioObjeto.Play(); }
}
