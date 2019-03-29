using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Real_Menu_manager : MonoBehaviour
{
    #region Declaracion de enums y gameObjects

    enum BackGround
    {
        None,MainMenu,
        CharacterOnePlayer,
        CharacterSeconPlayer
    }

    enum GroupButtons
    {
        GButtonPlay,GButtonOnePlayer,
        GButtonTwoPlayers,GExit
    }

    enum Buttons
    {
        ButtonPlay, ButtonOnePlayer,
        ButtonTwoPlayers, Exit
    }

    /// <summary>
    /// Esta variable define que canvas es el actual
    /// </summary>
    private BackGround backGround;


    //GameObjects de canvas
    public GameObject Title_Canvas;
    public GameObject Main_Menu_Canvas;
    public GameObject Character_Pick_One_Player;
    public GameObject Character_Pick_Two_Players_firstPlayer;
    public GameObject Character_Pick_Two_Players_secondPlayer;
    public GameObject Tracks_Screen;
    public GameObject Tracks_Screen_2P;

    //GameObjects de grupo de botones
    public GameObject Grupo_Boton_Jugar;
    public GameObject Grupo_Boton_UnJugador;
    public GameObject Grupo_Boton_DosJugadores;
    public GameObject Grupo_Boton_Salir;

    //GameObjects de botones
    public GameObject BotonJugar;
    public GameObject UnJugador;
    public GameObject DosJugadores;
    public GameObject BotonOpciones;
    public GameObject BotonSalir;


#endregion

    private bool Un_jugador=true;

    private void showCanvas(GameObject canvas)
    {
        HideAll();
        canvas.SetActive(true);

    }

    private void HideAll(){
        Title_Canvas.SetActive(false);
        Main_Menu_Canvas.SetActive(false);
        Character_Pick_One_Player.SetActive(false);
        Character_Pick_Two_Players_firstPlayer.SetActive(false);
        Character_Pick_Two_Players_secondPlayer.SetActive(false);
        Tracks_Screen.SetActive(false);
        Tracks_Screen_2P.SetActive(false);
    }

    public void ChangeScene(string _scene)
    {
        SceneManager.LoadScene(_scene, LoadSceneMode.Single);
    }

    public void ExitGame(){
        Application.Quit();
    }
  

    void Update(){
        if(Input.GetKeyDown("escape")){
            switch (backGround)
            {
                case  BackGround.None:
               showCanvas(Title_Canvas);
                break;

                case BackGround.MainMenu:
                showCanvas(Main_Menu_Canvas);
                    break;
                case BackGround.CharacterOnePlayer:
                if(Un_jugador){
                   showCanvas(Character_Pick_One_Player);
                   Un_jugador = false;
                }else{
                    showCanvas(Character_Pick_Two_Players_firstPlayer);
                    }
                break;
                case BackGround.CharacterSeconPlayer:
                showCanvas(Character_Pick_Two_Players_firstPlayer);
                break;
                default:
                    Grupo_Boton_Jugar.SetActive(true);
                    Grupo_Boton_Salir.SetActive(true);
                    Grupo_Boton_UnJugador.SetActive(false);
                    Grupo_Boton_DosJugadores.SetActive(false);
                    break;

            }
            
        }
    }

}
