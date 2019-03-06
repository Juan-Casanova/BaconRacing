using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MostrarItem : MonoBehaviour
{
    public Control_Cerdito controlCerdito;
    public ItemControl itemControl;
    public GameObject item1DejarTocino;
    public GameObject item2Escudo;
    public GameObject item3Mancha;
    public GameObject item4Acelerar;
    public GameObject item5DispararObjeto;

    public void Start()
    {
        desactivarIconosItems();
    }

    public void Update()
    {

        if (controlCerdito.activeItem)
        {
            ShowItem();
        }
        else
        {
            desactivarIconosItems();
        }
    }


    public void ShowItem()
    {

        switch (itemControl.getItemRandom())
        {
            case 1:
                mostrarItem1();
                break;
            case 2:
                mostrarItem2();

                break;
            case 3:
                mostrarItem3();
                break;

            case 4:
                mostrarItem4();

                break;

            case 5:
                mostrarItem5();

                break;

            default:
                desactivarIconosItems();
                break;
        }

    }

    public void desactivarIconosItems()
    {
        item1DejarTocino.GetComponent<Image>().enabled = false;
        item2Escudo.GetComponent<Image>().enabled = false;
        item3Mancha.GetComponent<Image>().enabled = false;
        item4Acelerar.GetComponent<Image>().enabled = false;
        item5DispararObjeto.GetComponent<Image>().enabled = false;

    }

    public void mostrarItem1()
    {
        item1DejarTocino.GetComponent<Image>().enabled = true;
        item2Escudo.GetComponent<Image>().enabled = false;
        item3Mancha.GetComponent<Image>().enabled = false;
        item4Acelerar.GetComponent<Image>().enabled = false;
        item5DispararObjeto.GetComponent<Image>().enabled = false;
    }

    public void mostrarItem2()
    {
        item1DejarTocino.GetComponent<Image>().enabled = false;
        item2Escudo.GetComponent<Image>().enabled = true;
        item3Mancha.GetComponent<Image>().enabled = false;
        item4Acelerar.GetComponent<Image>().enabled = false;
        item5DispararObjeto.GetComponent<Image>().enabled = false;
    }

    public void mostrarItem3()
    {
        item1DejarTocino.GetComponent<Image>().enabled = false;
        item2Escudo.GetComponent<Image>().enabled = false;
        item3Mancha.GetComponent<Image>().enabled = true;
        item4Acelerar.GetComponent<Image>().enabled = false;
        item5DispararObjeto.GetComponent<Image>().enabled = false;
    }

    public void mostrarItem4()
    {
        item1DejarTocino.GetComponent<Image>().enabled = false;
        item2Escudo.GetComponent<Image>().enabled = false;
        item3Mancha.GetComponent<Image>().enabled = false;
        item4Acelerar.GetComponent<Image>().enabled = true;
        item5DispararObjeto.GetComponent<Image>().enabled = false;
    }

    public void mostrarItem5()
    {
        item1DejarTocino.GetComponent<Image>().enabled = false;
        item2Escudo.GetComponent<Image>().enabled = false;
        item3Mancha.GetComponent<Image>().enabled = false;
        item4Acelerar.GetComponent<Image>().enabled = false;
        item5DispararObjeto.GetComponent<Image>().enabled = true;

    }

    
}
