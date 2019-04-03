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
        HideAllIcons();
    }

    public void ShowItem(int _numItem)
    {

        switch (_numItem)
        {
            case 1:
                ShowIconItem(item1DejarTocino);
                break;
            case 2:
                ShowIconItem(item2Acelerar);
                break;
            case 3:
                ShowIconItem(item3DispararObjeto);
                break;
            default:
                HideAllIcons();
                break;
        }

    }

    public void HideAllIcons()
    {
        item1DejarTocino.GetComponent<Image>().enabled = false;
        item2Acelerar.GetComponent<Image>().enabled = false;
        item3DispararObjeto.GetComponent<Image>().enabled = false;

    }

    public void ShowIconItem(GameObject icon)=>icon.GetComponent<Image>().enabled = true;

}
