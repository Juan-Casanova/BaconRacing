using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MostrarItem : MonoBehaviour, IMostrarItem, IOcultarItem // TODO Este nombre de clase está mal
{
    public GameObject[] itemsIcon;

    private MostrarItemEngine _MostrarItemEngine;
    //private MostrarItemEngine _OcultarItemEngine;
    private void Awake()
    {
        _MostrarItemEngine = new MostrarItemEngine(this, this);
        //_OcultarItemEngine = new MostrarItemEngine(this).OcultarItem;
    }

    public void Start() => HideAllItems();

    public void ShowIconItem(int index)
    {
        itemsIcon[index].GetComponent<Image>().enabled = true;
    }

    public void HideIconItem(int index)
    {
        itemsIcon[index].GetComponent<Image>().enabled = false;
    }

    //public void HideIconItem(GameObject icon) => icon.GetComponent<Image>().enabled = false;

    //public void ShowItem(int _numItem, numPlayer numPlayer)
    //{
    //    //_MostrarItemEngine.ShowItems( _numItem,numPlayer, itemsIcon);
    //    switch (_numItem)
    //    {
    //        case 1:

    //            ShowIconItem(numPlayer == numPlayer.p1 ? 0 : 3);

    //            break;
    //        case 2:

    //            ShowIconItem(numPlayer == numPlayer.p1 ? 2 : 5);


    //            break;
    //        case 3:

    //            ShowIconItem(numPlayer == numPlayer.p1 ? 1 : 4);

    //            break;
    //        default:
    //            HideAllItems();
    //            break;
    //    }
    //}

    public void HideAllItems()
    {
        for (int i = 0; i < itemsIcon.Length; i++)
            itemsIcon[i].GetComponent<Image>().enabled = false;
    }

    //public void HideItems(int _numItem, numPlayer numPlayer)
    //{
    //    switch (_numItem)
    //    {
    //        case 1:
    //            HideIconItem(numPlayer == numPlayer.p1 ? 0 : 3);

    //            break;
    //        case 2:
    //            HideIconItem(numPlayer == numPlayer.p1 ? 2 : 5);


    //            break;
    //        case 3:
    //            HideIconItem(numPlayer == numPlayer.p1 ? 1 : 4);

    //            break;
    //        default:
    //            HideAllItems();
    //            break;
    //    }
    //}
}