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

        }
        else
        {

        }
    }

    private IEnumerator changeNextTrack(string nextTrack, float distanceP1, float distanceP2)
    {
        if (distanceP1 >= distanceP2)
        {
            winner[0].enabled = true;
            winner[2].enabled = true;
        }
        else
        {
            winner[1].enabled = true;
            winner[3].enabled = true;
        }
        yield return new WaitForSeconds(4);

        SceneManager.LoadScene(nextTrack, LoadSceneMode.Single);
    }
}
