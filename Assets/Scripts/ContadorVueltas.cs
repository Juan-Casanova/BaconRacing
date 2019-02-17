using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ContadorVueltas : MonoBehaviour
{  
    public Transform[] checkpointArray;
    public static Transform[] checkpointA;
    public static int currentCheckpoint = 0;
    public static int currentLap = 0;
    static Vector3 starPos;
    public int Lap;
    public Text Vueltas;
    // Use this for initialization
    void Start ()
    {
        starPos = transform.position;
        currentCheckpoint = 0;
        //currentLap = -1;
    }
	
	// Update is called once per frame
	void Update ()
    {
        Lap = currentLap;
        checkpointA = checkpointArray;
        Vueltas.text="VUELTA "+currentLap;
    }
}

