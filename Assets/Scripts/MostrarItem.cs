using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MostrarItem : MonoBehaviour
{

    public ItemControl itemControl;
    public GameObject item1DejarTocino;
    public GameObject item2Escudo;
    public GameObject item3Mancha;
    public GameObject item4Acelerar;
    public GameObject item5DispararObjeto;
    public int _numRandom;

    public void Start()
    {
        desactivarIconosItems();
    }


    public void ShowItem(int _numItem)
    {

        switch (_numItem)
        {
            case 1:
                desactivarIconosItems();
                item1DejarTocino.GetComponent<Image>().enabled = true;
                break;
            case 2:
                desactivarIconosItems();
                item2Escudo.GetComponent<Image>().enabled = true;
                break;
            case 3:
                desactivarIconosItems();
                item3Mancha.GetComponent<Image>().enabled = true;
                break;

            case 4:
                desactivarIconosItems();
                item4Acelerar.GetComponent<Image>().enabled = true;

                break;

            case 5:
                desactivarIconosItems();
                item5DispararObjeto.GetComponent<Image>().enabled = true;
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

   
    
}
