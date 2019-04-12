using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MostrarItem : MonoBehaviour
{
<<<<<<< HEAD
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
=======
   
    public GameObject[] itemsIcon;

    public void Start() => HideAllItems();
>>>>>>> Feature/IntegracionCodigoSonidoYEfecto

    public void ShowItem(int _numItem,MovimientoCerdo.numPlayer numPlayer)
    {
<<<<<<< HEAD
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
=======
        switch (_numItem)
        {
            case 1:
                if (numPlayer == MovimientoCerdo.numPlayer.p1)
                {
                    ShowIconItem(itemsIcon[0]);
                }
                else
                {
                    ShowIconItem(itemsIcon[3]);
                }

                break;
            case 2:
                if (numPlayer == MovimientoCerdo.numPlayer.p1)
                {
                    ShowIconItem(itemsIcon[1]);
                }
                else
                {
                    ShowIconItem(itemsIcon[4]);
                }

                break;
            case 3:
                if (numPlayer == MovimientoCerdo.numPlayer.p1)
                {
                    ShowIconItem(itemsIcon[2]);
                }
                else
                {
                    ShowIconItem(itemsIcon[5]);
                }
>>>>>>> Feature/IntegracionCodigoSonidoYEfecto

                break;
            default:
               HideAllItems();
                break;
        }
    }

    public void HideAllItems()
    {
        for (int i = 0; i < itemsIcon.Length; i++)
        {
            itemsIcon[i].GetComponent<Image>().enabled = false;
        }
    }

    public void ShowIconItem(GameObject icon)=>icon.GetComponent<Image>().enabled = true;

}
