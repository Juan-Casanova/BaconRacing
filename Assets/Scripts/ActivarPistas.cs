using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarPistas : MonoBehaviour
{
    #region BotonesPista
    public UnityEngine.UI.Button PistaMexicobtn;
    public UnityEngine.UI.Button PistaBosquebtn;
    public UnityEngine.UI.Button PistaSaltarinbtn;
    public UnityEngine.UI.Button PistaFranciabtn;
    #endregion

    Real_Menu_manager realMenuManager = new Real_Menu_manager();
    private void Start()
    {
        ActivarPista();
    }
    void ActivarPista()
    {
        Debug.Log("entramos");
        Debug.Log(realMenuManager.PistaMexicoActiva);

        if (realMenuManager.PistaMexicoActiva == true)
        {
            PistaMexicobtn.interactable = true;
        }
        if (realMenuManager.PistaFranciaActiva == true)
        {
            PistaFranciabtn.interactable = true;
        }
        if (realMenuManager.PistaSaltarinaActiva == true)
        {
            PistaSaltarinbtn.interactable = true;
        }
        if (realMenuManager.PistaBosqueActiva == true)
        {
            PistaBosquebtn.interactable = true;
        }
    }
}
