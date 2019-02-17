using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Hover_image_change : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public Image myImageComponent;
    public Sprite Sprite_Correspondiente; //Drag your first sprite here in inspector.

    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        //Output to console the GameObject's name and the following message
        Debug.Log("Cursor Entering " + name + " GameObject");
   
        myImageComponent.sprite = Sprite_Correspondiente;
    }

    //Detect when Cursor leaves the GameObject
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        //Output the following message with the GameObject's name
        Debug.Log("Cursor Exiting " + name + " GameObject");
       // myImageComponent.sprite = Sprite_Crash;
    }

}
