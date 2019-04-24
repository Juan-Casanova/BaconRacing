using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MostrarItem : MonoBehaviour
{
    public GameObject[] itemsIcon;

    public void Start() => HideAllItems();
    
    public void ShowIconItem(GameObject icon) => icon.GetComponent<Image>().enabled = true;

    public void ShowItem(int _numItem,MovimientoCerdo.numPlayer numPlayer)
    {
        
        switch (_numItem)
        {
            case 1:
                ShowIconItem(numPlayer == MovimientoCerdo.numPlayer.p1 ? itemsIcon[0] : itemsIcon[3]);

                break;
            case 2:
                ShowIconItem(numPlayer == MovimientoCerdo.numPlayer.p1 ? itemsIcon[1] : itemsIcon[4]);

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

                break;
            default:
                HideAllItems();
                break;
        }
    }
        


    public void HideAllItems()
    {
        for (int i = 0; i < itemsIcon.Length; i++)
            itemsIcon[i].GetComponent<Image>().enabled = false;
    }

}