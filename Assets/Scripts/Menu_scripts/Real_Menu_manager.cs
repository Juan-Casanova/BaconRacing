using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Real_Menu_manager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Title_Canvas;

    public GameObject Main_Menu_Canvas;
    public GameObject Character_Pick_One_Player;
    public GameObject Character_Pick_Two_Players_firstPlayer;
    public GameObject Character_Pick_Two_Players_secondPlayer;
    public GameObject Tracks_Screen;
    public GameObject Tracks_Screen_2P;

    public GameObject Menu_Opciones;

    private bool Un_jugador=true;
    private int Input_Regreso =0;


    public void To_Title_Screen(){
        SetEverythingFalse();
        Title_Canvas.SetActive(true);
        Input_Regreso = 0;
    }

    public void To_Main_Menu(){
        SetEverythingFalse();
        Main_Menu_Canvas.SetActive(true);
        Input_Regreso = 0;
        }

    public void Character_Screen_One_Player(){
        SetEverythingFalse();
        Character_Pick_One_Player.SetActive(true);
        Un_jugador=true;
        Input_Regreso = 2;
        
    }

    public void Character_Screen_Two_Player_Firstplayer(){
        SetEverythingFalse();
        Character_Pick_Two_Players_firstPlayer.SetActive(true);
        Un_jugador=false;
        Input_Regreso = 3;    
    }

    public void Character_Screen_Two_Player_secondplayer(){
        SetEverythingFalse();
        Character_Pick_Two_Players_secondPlayer.SetActive(true);
        Un_jugador=false;
        Input_Regreso = 6;    
    }

     public void To_Tracks_Screen(){
        SetEverythingFalse();
        Tracks_Screen.SetActive(true);
        Input_Regreso = 4;
    }

    public void To_Tracks_Screen_2P(){
        SetEverythingFalse();
        Tracks_Screen_2P.SetActive(true);
        Input_Regreso = 7;
    }

    public void To_Menu_Opciones(){
        SetEverythingFalse();
        Menu_Opciones.SetActive(true);
        Input_Regreso=5;
    }

    public void SetEverythingFalse(){
        Title_Canvas.SetActive(false);
        Main_Menu_Canvas.SetActive(false);
        Character_Pick_One_Player.SetActive(false);
        Character_Pick_Two_Players_firstPlayer.SetActive(false);
            Character_Pick_Two_Players_secondPlayer.SetActive(false);
        Tracks_Screen.SetActive(false);
            Tracks_Screen_2P.SetActive(false);
        Menu_Opciones.SetActive(false);
    }

    public GameObject Grupo_Boton_Jugar;
        public GameObject Grupo_Boton_UnJugador;

        public GameObject Grupo_Boton_DosJugadores;
   
    public GameObject Grupo_Boton_Opciones;
    public GameObject Grupo_Boton_Salir;

    private void reorganizarMenuPrincipal(){
        Grupo_Boton_Jugar.SetActive(true);
            Grupo_Boton_UnJugador.SetActive(false);
            Grupo_Boton_DosJugadores.SetActive(false);
        //Grupo_Boton_Opciones.SetActive(true);
        Grupo_Boton_Salir.SetActive(true);
    }
    ///////////////////////////


    //Metodo para cambiar la escena, agregarlo a un boton
    public void Escribe_Escena(string _scene)
    {
        SceneManager.LoadScene(_scene, LoadSceneMode.Single);
    }

    public void SalirJuego(){
        Debug.Log("Saliendo del Juego");
        Application.Quit();
    }
    ///////////////////////////////
    //Este script te manda para escoger uno o dos jugadores

    public GameObject BotonJugar;
        public GameObject UnJugador;
        public GameObject DosJugadores;
    
    public GameObject BotonOpciones;
    public GameObject BotonSalir;


    public void JugarJuego(){
        BotonJugar.SetActive(false);
            UnJugador.SetActive(true);
            DosJugadores.SetActive(true);
        
        BotonOpciones.SetActive(false);

        BotonSalir.SetActive(false);
    }
    /////////////////////////////////


    void Update(){
        if(Input.GetKeyDown("escape")){
            Debug.Log("Presionando escape");


            switch (Input_Regreso)
            {
                case 1:
               // Input_Regreso = 0;
                To_Main_Menu();
                break;

                case 2:
                To_Main_Menu();
                break;

                case 3:
                To_Main_Menu();
                break;

                case 4:
                if(Un_jugador){
                   Character_Screen_One_Player(); 
                }else{
                    Character_Screen_Two_Player_Firstplayer();
                }
                break;

                case 5:
                To_Main_Menu();
                break;

                case 6:
                Character_Screen_Two_Player_Firstplayer();
                break;

                case 7:
                To_Main_Menu();
                break;

                default:
                reorganizarMenuPrincipal();
                Debug.Log("Hay un bug papu");
                break;

            }
            
        }
    }

}
