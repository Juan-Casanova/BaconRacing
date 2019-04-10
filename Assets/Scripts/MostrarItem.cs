using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MostrarItem : MonoBehaviour
{
    public GameObject item1DejarTocino1;
    public GameObject item2DispararBotella1;
    public GameObject item3Velocidad1;

    public GameObject item1DejarTocino2;
    public GameObject item2DispararBotella2;
    public GameObject item3Velocidad2;

    public void Start()
    {
        HideAllIcons();
    }

    public void ShowItem(int _numItem,MovimientoCerdo.numPlayer numPlayer)
    {
        if (numPlayer == 0)
        {
            switch (_numItem)
            {
                case 1:
                    ShowIconItem(item1DejarTocino1);
                    break;
                case 2:
                    ShowIconItem(item2DispararBotella1);
                    break;
                case 3:
                    ShowIconItem(item3Velocidad1);
                    break;
                default:
                    HideAllIcons();
                    break;
            }
        }
        else
        {
            switch (_numItem)
            {
                case 1:
                    ShowIconItem(item1DejarTocino2);
                    break;
                case 2:
                    ShowIconItem(item2DispararBotella2);
                    break;
                case 3:
                    ShowIconItem(item3Velocidad2);
                    break;
                default:
                    HideAllIcons();
                    break;
            }
        }
        

    }

    public void HideAllIcons()
    {
        item1DejarTocino1.GetComponent<Image>().enabled = false;
        item2DispararBotella1.GetComponent<Image>().enabled = false;
        item3Velocidad1.GetComponent<Image>().enabled = false;

        item1DejarTocino2.GetComponent<Image>().enabled = false;
        item2DispararBotella2.GetComponent<Image>().enabled = false;
        item3Velocidad2.GetComponent<Image>().enabled = false;

    }

    public void ShowIconItem(GameObject icon)=>icon.GetComponent<Image>().enabled = true;

}
