using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform player1SpawnPoint, player2SpawnPoint;
    
    public delegate void OnPlayersSpawn();
    public static event OnPlayersSpawn PlayersSpawnEvent;
    
    // Start is called before the first frame update
    void Start()
    {
        SpawnPlayers();       
    }

    public void SpawnPlayers()
    {
        GameManager.instancia.player1Instancia = Instantiate(GameManager.instancia.player1Prefab, player1SpawnPoint.position, player1SpawnPoint.rotation);
        GameManager.instancia.player2Instancia = Instantiate(GameManager.instancia.player2Prefab, player2SpawnPoint.position, player2SpawnPoint.rotation);
        if(PlayersSpawnEvent != null) PlayersSpawnEvent();

    }
}
