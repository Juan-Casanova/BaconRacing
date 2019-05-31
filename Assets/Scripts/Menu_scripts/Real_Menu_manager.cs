using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using JetBrains.Annotations;


public class Real_Menu_manager : MonoBehaviour
{
    private enum BackTarget
	{
		None,
		MainMenu,
		CharacterSelectSinglePlayer,
		CharacterSelectMultiPlayer
	}

    #region VarPista

    public int PistaMexicoActiva;
    public int PistaBosqueActiva;
    public int PistaFranciaActiva;
    public int PistaSaltarinaActiva;
    public int Saldo;

    #endregion


    #region BotonesPista
    public UnityEngine.UI.Button PistaMexicobtn;
    public UnityEngine.UI.Button PistaBosquebtn;
    public UnityEngine.UI.Button PistaSaltarinbtn;
    public UnityEngine.UI.Button PistaFranciabtn;
    #endregion


    #region Canvas para activar/desactivar

    public GameObject Title_Canvas;
	public GameObject Main_Menu_Canvas;
	public GameObject Character_Pick_One_Player;
	public GameObject Character_Pick_Two_Players_firstPlayer;
	public GameObject Character_Pick_Two_Players_secondPlayer;
	public GameObject Tracks_Screen;
	public GameObject Tracks_Screen_2P;
	public GameObject Menu_Opciones;

	#endregion

	private BackTarget Input_Regreso = BackTarget.None;

	#region GoToScreen
	public void To_Title_Screen() => goToScreen(Title_Canvas, BackTarget.None);

	public void To_Main_Menu() => goToScreen(Main_Menu_Canvas, BackTarget.None);

	public void Character_Screen_One_Player() => goToScreen(Character_Pick_One_Player, BackTarget.MainMenu);

	public void Character_Screen_Two_Player_Firstplayer() => goToScreen(Character_Pick_Two_Players_firstPlayer, BackTarget.MainMenu);

	public void Character_Screen_Two_Player_secondplayer() => goToScreen(Character_Pick_Two_Players_secondPlayer, BackTarget.CharacterSelectMultiPlayer);

	public void To_Tracks_Screen() => goToScreen(Tracks_Screen, BackTarget.MainMenu);

	public void To_Tracks_Screen_2P() => goToScreen(Tracks_Screen_2P, BackTarget.CharacterSelectMultiPlayer);

	private void goToScreen(GameObject canvas, BackTarget backTarget)
	{
		show(canvas);
		Input_Regreso = backTarget;
	}

	private void show(GameObject canvas)
	{
		Title_Canvas.SetActive(false);
		Main_Menu_Canvas.SetActive(false);
		Character_Pick_One_Player.SetActive(false);
		Character_Pick_Two_Players_firstPlayer.SetActive(false);
		Character_Pick_Two_Players_secondPlayer.SetActive(false);
		Tracks_Screen.SetActive(false);
		Tracks_Screen_2P.SetActive(false);
		Menu_Opciones.SetActive(false);

		canvas.SetActive(true);
	}
	#endregion

	public void Escribe_Escena(string _scene) => SceneManager.LoadScene(_scene, LoadSceneMode.Single);

	public void SalirJuego() => Application.Quit();


    public void Start()
    {
        ActualizarVal();
        ActivarPista();
    }



    public void ActualizarVal()
    {
        PistaMexicoActiva = PlayerPrefs.GetInt("PistaMexicoActiva");
        PistaBosqueActiva = PlayerPrefs.GetInt("PistaBosqueActiva");
        PistaFranciaActiva = PlayerPrefs.GetInt("PistaFranciaActiva");
        PistaSaltarinaActiva = PlayerPrefs.GetInt("PistaSaltarinaActiva");
        Saldo = PlayerPrefs.GetInt("Saldo", 0);
    }




    private void Update()
	{
		if (Input.GetKeyDown("escape"))
		{
			//Debug.Log("Presionando escape");

			switch (Input_Regreso)
			{
				case BackTarget.MainMenu:
					To_Main_Menu();
					break;
				case BackTarget.CharacterSelectMultiPlayer:
					Character_Screen_Two_Player_Firstplayer();
					break;
				case BackTarget.CharacterSelectSinglePlayer:
					Character_Screen_One_Player();
					break;
				default:
					ShowButtonsForNumberOfPlayers(false);
					Debug.Log("Hay un bug papu");
					break;
			}
		}
	}

	#region Reorganizar menu
	public GameObject Grupo_Boton_Jugar;
	public GameObject Grupo_Boton_UnJugador;
	public GameObject Grupo_Boton_DosJugadores;
	public GameObject Grupo_Boton_Salir;
    public GameObject Grupo_Boton_Tienda;

    public void ShowButtonsForNumberOfPlayers(bool show)
	{
		Grupo_Boton_Jugar.SetActive(!show);
		Grupo_Boton_Salir.SetActive(!show);
        Grupo_Boton_Tienda.SetActive(!show);
        //Grupo_Boton_UnJugador.SetActive(show);
        Grupo_Boton_DosJugadores.SetActive(show);
	}

    #endregion

    void ActivarPista()
    {
        Debug.Log(PistaFranciaActiva);
        ActualizarVal();
        if (PistaMexicoActiva == 1)
        {
            PistaMexicobtn.interactable = true;
        }
        if (PistaFranciaActiva == 1)
        {
            PistaFranciabtn.interactable = true;
        }
        if (PistaSaltarinaActiva == 1)
        {
            PistaSaltarinbtn.interactable = true;
        }
        if (PistaBosqueActiva == 1)
        {
            PistaBosquebtn.interactable = true;
        }
    }
}