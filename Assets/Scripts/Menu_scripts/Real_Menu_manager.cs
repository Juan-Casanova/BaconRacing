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
    private string rutaArchivo;

    public int Saldo;

    public Text SaldoInf;

    private enum BackTarget
	{
		None,
		MainMenu,
		CharacterSelectSinglePlayer,
		CharacterSelectMultiPlayer
	}

    #region VarPista

    public bool PistaMexicoActiva;
    public bool PistaBosqueActiva;
    public bool PistaFranciaActiva;
    public bool PistaSaltarinaActiva;

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
    static bool PrimeraVez = true;

    public void Start()
    {
        ActivarPista();
    }

    void Awake()
    {
        rutaArchivo = Application.persistentDataPath + "/datos1.data";
        if (PrimeraVez)
        {
            Cargar();
            PrimeraVez = false;
        }
    }

    private void Update()
	{
		if (Input.GetKeyDown("escape"))
		{
			Debug.Log("Presionando escape");

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

    public void GuardarPistaFrancia()
    {
        if (Saldo >= 24)
        {
            Saldo = Saldo - 24;
            PistaFranciaActiva = true;
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Create(rutaArchivo);
            DatosAGuardarPistas datos1 = new DatosAGuardarPistas(PistaMexicoActiva, PistaBosqueActiva, PistaFranciaActiva, PistaSaltarinaActiva, Saldo);
            bf.Serialize(file, datos1);
            file.Close();
            
        }
        else
        {
            SaldoInf.gameObject.SetActive(true);
        }
    }
    public void GuardarPistaBosque()
    {
        if (Saldo >= 16)
        {
            Saldo = Saldo - 16;
            PistaMexicoActiva = true;
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Create(rutaArchivo);
            DatosAGuardarPistas datos1 = new DatosAGuardarPistas(PistaMexicoActiva, PistaBosqueActiva, PistaFranciaActiva, PistaSaltarinaActiva, Saldo);
            bf.Serialize(file, datos1);
            file.Close();
           
        }
        else
        {
            SaldoInf.gameObject.SetActive(true);
        }
    }
    public void GuardarPistaMexico()
    {
        if (Saldo>=12)
        {
            Saldo = Saldo - 12;
            PistaBosqueActiva = true;
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Create(rutaArchivo);
            DatosAGuardarPistas datos1 = new DatosAGuardarPistas(PistaMexicoActiva, PistaBosqueActiva, PistaFranciaActiva, PistaSaltarinaActiva, Saldo);
            bf.Serialize(file, datos1);
            file.Close();
           
        }
        else
        {
            SaldoInf.gameObject.SetActive(true);
        }
    }
    public void GuardarPistaSaltarina()
    {
        if (Saldo >=20)
        {
            Saldo = Saldo - 20;
            PistaSaltarinaActiva = true;
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Create(rutaArchivo);
            DatosAGuardarPistas datos1 = new DatosAGuardarPistas(PistaMexicoActiva, PistaBosqueActiva, PistaFranciaActiva, PistaSaltarinaActiva, Saldo);
            bf.Serialize(file, datos1);
            file.Close();
            
        }
        else
        {
            SaldoInf.gameObject.SetActive(true);
        }
    }

    public void GuardarSaldo()
    {
        Saldo=Saldo+4;
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(rutaArchivo);
        DatosAGuardarPistas datos1 = new DatosAGuardarPistas(PistaMexicoActiva, PistaBosqueActiva, PistaFranciaActiva, PistaSaltarinaActiva,Saldo);
        bf.Serialize(file, datos1);
        file.Close();

        Debug.Log(Saldo);
        //ActivarPista();
    }

    public void Cargar()
    {
        if (File.Exists(rutaArchivo))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(rutaArchivo, FileMode.Open);
            DatosAGuardarPistas datos1 = (DatosAGuardarPistas)bf.Deserialize(file);
            PistaFranciaActiva = datos1.PistaFranciaActiva;
            PistaBosqueActiva = datos1.PistaBosqueActiva;
            PistaMexicoActiva = datos1.PistaMexicoActiva;
            PistaSaltarinaActiva = datos1.PistaSaltarinaActiva;
            Saldo = datos1.Saldo;
        }
        else
        {
            PistaFranciaActiva = false;
            PistaBosqueActiva = false;
            PistaMexicoActiva = false;
            PistaSaltarinaActiva = false;
            Saldo = 12;
        }
    }

   void ActivarPista()
    {
        if (PistaMexicoActiva==true)
        {
            PistaMexicobtn.interactable = true;
        }
        if (PistaFranciaActiva == true)
        {
            PistaFranciabtn.interactable = true;
        }
        if (PistaSaltarinaActiva == true)
        {
            PistaSaltarinbtn.interactable = true;
        }
        if (PistaBosqueActiva == true)
        {
            PistaBosquebtn.interactable = true;
        }
    }
}
[System.Serializable]
class DatosAGuardarPistas
{
    public bool PistaMexicoActiva;
    public bool PistaBosqueActiva;
    public bool PistaFranciaActiva;
    public bool PistaSaltarinaActiva;
    public int Saldo;

    public DatosAGuardarPistas(bool PistaMexicoActiva_, bool PistaBosqueActiva_, bool PistaFranciaActiva_, bool PistaSaltarinaActiva_, int Saldo_)
    {
        PistaBosqueActiva = PistaBosqueActiva_;
        PistaFranciaActiva = PistaFranciaActiva_;
        PistaMexicoActiva = PistaMexicoActiva_;
        PistaSaltarinaActiva = PistaSaltarinaActiva_;
        Saldo = Saldo_;
    }
}