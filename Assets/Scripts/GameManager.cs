using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instancia;

    public GameObject player1Prefab, player2Prefab;
    public GameObject player1Instancia, player2Instancia;

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

        Time.timeScale = 0.1f;
        StartCoroutine(changeNextTrack("Menu_Principal"));

    }

    private IEnumerator changeNextTrack(string nextTrack)
    {
        
        yield return new WaitForSecondsRealtime(4);

        SceneManager.LoadScene(nextTrack, LoadSceneMode.Single);
    }
}
