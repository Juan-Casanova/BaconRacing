using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Real_Menu_manager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Title_Canvas;

    public GameObject Main_Menu_Canvas;
    public GameObject Character_Pick_One_Player;
    public GameObject Character_Pick_Two_Players;
    public GameObject Tracks_Screen;


    public void To_Title_Screen(){
        SetEverythingFalse();
        Title_Canvas.SetActive(true);
    }

    public void To_Main_Menu(){
        SetEverythingFalse();
        Main_Menu_Canvas.SetActive(true);
        }

    public void Character_Screen_One_Player(){
        SetEverythingFalse();
        Character_Pick_One_Player.SetActive(true);
        
    }

    public void Character_Screen_Two_Player(){
        SetEverythingFalse();
        Character_Pick_Two_Players.SetActive(true);    
    }

     public void To_Tracks_Screen(){
        SetEverythingFalse();
        Tracks_Screen.SetActive(true);
    }

    public void SetEverythingFalse(){
         Title_Canvas.SetActive(false);
        Main_Menu_Canvas.SetActive(false);
        Character_Pick_One_Player.SetActive(false);
        Character_Pick_Two_Players.SetActive(false);
        Tracks_Screen.SetActive(false);
    }
}
