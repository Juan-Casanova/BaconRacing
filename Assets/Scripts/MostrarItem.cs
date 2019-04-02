using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MostrarItem : MonoBehaviour
{
    public GameObject item1DejarTocino;
    public GameObject item2Acelerar;
    public GameObject item3DispararObjeto;

    public void Start() => HideAllIconosItems();

    public void ShowItem(int _numItem)
    {

        switch (_numItem)
        {
            case 1:
                activateImageItem(item1DejarTocino);
                break;
            case 2:
                activateImageItem(item2Acelerar);
                break;
            case 3:
                activateImageItem(item3DispararObjeto);
                break;
            default:
                HideAllIconosItems();
                break;
        }

    }

    public void HideAllIconosItems()
    {
        item1DejarTocino.GetComponent<Image>().enabled = false;
        item2Acelerar.GetComponent<Image>().enabled = false;
        item3DispararObjeto.GetComponent<Image>().enabled = false;
    }

    public void activateImageItem(GameObject imageItem)
    {
        HideAllIconosItems();
        imageItem.GetComponent<Image>().enabled = true;
    }



}
