using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MostrarItem : MonoBehaviour
{
    public GameObject item1DejarTocino;
    public GameObject item2Acelerar;
    public GameObject item3DispararObjeto;

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
                item2Acelerar.GetComponent<Image>().enabled = true;
                break;
            case 3:
                desactivarIconosItems();
                item3DispararObjeto.GetComponent<Image>().enabled = true;
                break;
            default:
                desactivarIconosItems();
                break;
        }

    }

    public void desactivarIconosItems()
    {
        item1DejarTocino.GetComponent<Image>().enabled = false;
        item2Acelerar.GetComponent<Image>().enabled = false;
        item3DispararObjeto.GetComponent<Image>().enabled = false;

    }

}
