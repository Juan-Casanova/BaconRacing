using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuDios : MonoBehaviour
{
    public void cargaMenuPrincipal( string pNombreEscena)
    {
        SceneManager.LoadScene(pNombreEscena);
    }
}
