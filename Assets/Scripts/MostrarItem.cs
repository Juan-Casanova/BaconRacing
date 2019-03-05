using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MostrarItem : MonoBehaviour
{
    public GameObject item1DejarTocino;
    public GameObject item2Escudo;
    public GameObject item3Mancha;
    public GameObject item4Acelerar;
    public GameObject item5DispararObjeto;

    public void Start()
    {
        desactivarIconosItems();
       
    }

    public void desactivarIconosItems()
    {
        item1DejarTocino.SetActive(false);
        item2Escudo.SetActive(false);
        item3Mancha.SetActive(false);
        item4Acelerar.SetActive(false);
        item5DispararObjeto.SetActive(false);
    }

    public void mostrarItem1()
    {
        item1DejarTocino.SetActive(true);

    }

    public void mostrarItem2()
    {
        item2Escudo.SetActive(true);

    }

    public void mostrarItem3()
    {
        item3Mancha.SetActive(true);

    }

    public void mostrarItem4()
    {
        item4Acelerar.SetActive(true);

    }

    public void mostrarItem5()
    {
        item5DispararObjeto.SetActive(true);

    }

    
}
