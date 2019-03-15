using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeVoleaste : MonoBehaviour
{
public bool estasAbajo;

public void Start()
{
    estasAbajo=false;
}

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("IconMiniMap"))
        {
           estasAbajo=true;
           Debug.Log("ChoqueIcono");
        }
    }
}
