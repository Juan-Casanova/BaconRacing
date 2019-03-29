using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MostrarItem : MonoBehaviour
{
    #region Declaracion gameObjectss

    public GameObject item1DejarTocino;
    public GameObject item2Acelerar;
    public GameObject item3DispararObjeto;
#endregion

    public void ShowItem(int numRandom)
    {

        switch (numRandom)
        {
            case 1:
                showIconItem(item1DejarTocino.GetComponent<Image>());
                break;
            case 2:
                showIconItem(item2Acelerar.GetComponent<Image>());
                break;
            case 3:
                showIconItem(item3DispararObjeto.GetComponent<Image>());
                break;
            default:
                hideAllIconItems();
                break;
        }

    }

    public void showIconItem(Image iconItem)
    {
        hideAllIconItems();
        iconItem.enabled = true;
    }
    
    private void hideAllIconItems()
    {
        item1DejarTocino.GetComponent<Image>().enabled = false;
        item2Acelerar.GetComponent<Image>().enabled = false;
        item3DispararObjeto.GetComponent<Image>().enabled = false;

    }

}
