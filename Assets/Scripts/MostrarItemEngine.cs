using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostrarItemEngine
{
    public MostrarItem MostrarItem;
    public void ShowItems(int _numItem, numPlayer numPlayer, GameObject[] itemsIcon)
    {
        switch (_numItem)
        {
            case 1:

                MostrarItem.ShowIconItem(numPlayer == numPlayer.p1 ? itemsIcon[0] : itemsIcon[3]);

                break;
            case 2:

                MostrarItem.ShowIconItem(numPlayer == numPlayer.p1 ? itemsIcon[2] : itemsIcon[5]);


                break;
            case 3:

                MostrarItem.ShowIconItem(numPlayer == numPlayer.p1 ? itemsIcon[1] : itemsIcon[4]);

                break;
            default:
                MostrarItem.HideAllItems();
                break;
        }
    }
}
