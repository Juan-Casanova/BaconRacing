using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPlayer : MonoBehaviour
{
    public RespawnPlayerEngine respawnPlayerEngine=new RespawnPlayerEngine();

    public int numPlayer;
    public GameObject[] player;


    public int numSpawn;
    public GameObject[] spawnLocations;

    public void Start()
    {
        spawnLocations = GameObject.FindGameObjectsWithTag("spawn");
        numSpawn = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("caida"))
        {
            player[numPlayer].transform.position = new Vector3(spawnLocations[numSpawn].transform.position.x, spawnLocations[numSpawn].transform.position.y, spawnLocations[numSpawn].transform.position.z);
            player[numPlayer].transform.eulerAngles = new Vector3(spawnLocations[numSpawn].transform.eulerAngles.x - 45, spawnLocations[numSpawn].transform.eulerAngles.y, spawnLocations[numSpawn].transform.eulerAngles.z);

        }
        else if (other.CompareTag("spawn"))
        {
            numSpawn=respawnPlayerEngine.IncreaseNumSpawn();
        }

    }

}
