using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour, IMeta
{


    public static GameManager instancia;

    public GameObject player1Prefab, player2Prefab;
    public GameObject player1Instancia, player2Instancia;


    public GameObject SrTequilaP1, SrTequilaP2;
    public GameObject SakeP1, SakeP2;
    public GameObject CuauhtemocP1, CuauhtemocP2;
    public GameObject AlemanaP1, AlemanaP2;

    void Awake()
    {
        

        if (instancia == null)
        {
            instancia = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
        }

    }

    //este no se puede probar
    public void GameOver(GameObject winner)
    {   
        if(winner == player1Instancia)
        {
            managerHUD.instancia.ShowGameResults(numPlayer.p1);
        }
        else
        {
            managerHUD.instancia.ShowGameResults(numPlayer.p2);
        }

        Time.timeScale = 0.01f;
        StartCoroutine(changeNextTrack("Menu_Principal"));

    }

    private IEnumerator changeNextTrack(string nextTrack)
    {
        
        yield return new WaitForSecondsRealtime(8);

        SceneManager.LoadScene(nextTrack, LoadSceneMode.Single);
    }

    //no se puede probar
    public void PickCharacterSrTequilaP1() => player1Prefab = SrTequilaP1;

    public void PickCharacterSrTequilaP2()=>player2Prefab = SrTequilaP2;

    public void PickCharacterSakeP1()=>player1Prefab = SakeP1;


    public void PickCharacterSakeP2()=>player2Prefab = SakeP2;


    public void PickCharacterCuauhtemocP1()=>player1Prefab = CuauhtemocP1;

    public void PickCharacterCuauhtemocP2()=>player2Prefab = CuauhtemocP2;
    

    public void PickCharacterAlemanaP1()=>player1Prefab = AlemanaP1;

    public void PickCharacterAlemanaP2()=>player2Prefab = AlemanaP2;
}
