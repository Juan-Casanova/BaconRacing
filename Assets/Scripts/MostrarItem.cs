using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MostrarItem : MonoBehaviour, IMostrarItem // TODO Este nombre de clase está mal
{
    public GameObject[] itemsIcon;

    private MostrarItemEngine _MostrarItemEngine;
    private void Awake()
    {
	    _MostrarItemEngine = new MostrarItemEngine(this);
    }

    public void Start() => HideAllItems();
    
    public void ShowIconItem(int index)
    {
	    itemsIcon[index].GetComponent<Image>().enabled = true;
    }

    public void HideIconItem(GameObject icon) => icon.GetComponent<Image>().enabled = false;

    public void ShowItem(int _numItem,numPlayer numPlayer)
    {
        //_MostrarItemEngine.ShowItems( _numItem,numPlayer, itemsIcon);
        switch (_numItem)
        {
            case 1:

                ShowIconItem(numPlayer == numPlayer.p1 ? 0 : 3);

                break;
            case 2:

                ShowIconItem(numPlayer == numPlayer.p1 ? 2 : 5);


                break;
            case 3:

                ShowIconItem(numPlayer == numPlayer.p1 ? 1 : 4);

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

    public void HideItem(int _numItem, numPlayer numPlayer)
    {
        switch (_numItem)
        {
            case 1:
                HideIconItem(numPlayer == numPlayer.p1 ? itemsIcon[0] : itemsIcon[3]);

                break;
            case 2:
                HideIconItem(numPlayer == numPlayer.p1 ? itemsIcon[2] : itemsIcon[5]);


                break;
            case 3:
                HideIconItem(numPlayer == numPlayer.p1 ? itemsIcon[1] : itemsIcon[4]);

                break;
            default:
                HideAllItems();
                break;
        }
    }
}