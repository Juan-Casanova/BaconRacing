using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MostrarItem : MonoBehaviour
{
    public GameObject item1DejarTocino;
    public GameObject item2DispararBotella;
    public GameObject item3Velocidad;

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
                ShowIconItem(item2DispararBotella);
                break;
            case 3:
                ShowIconItem(item3Velocidad);
                break;
            default:
                HideAllIcons();
                break;
        }

    }

    public void HideAllIcons()
    {
        item1DejarTocino.GetComponent<Image>().enabled = false;
        item2DispararBotella.GetComponent<Image>().enabled = false;
        item3Velocidad.GetComponent<Image>().enabled = false;

    }

    public void ShowIconItem(GameObject icon)=>icon.GetComponent<Image>().enabled = true;

}
