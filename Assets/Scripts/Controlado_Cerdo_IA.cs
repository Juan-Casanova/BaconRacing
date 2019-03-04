using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SocialPlatforms;

public class Controlado_Cerdo_IA: MonoBehaviour
{
    private ControladorCerditoIAEngine controladorCerditoIaEngine;
    public Countdown countdown;

    public GameObject[] waypoints;
    public int num=0;

    public float minDist;
    public float speed;

    public bool rand=false;
    public bool go =true;

    void Start()
    {
        
        controladorCerditoIaEngine.minDistance = minDist;
        controladorCerditoIaEngine.rand = rand;
        controladorCerditoIaEngine.go = go;
        controladorCerditoIaEngine.countDownEngine = countdown.movement;
        controladorCerditoIaEngine.num = num;
        controladorCerditoIaEngine.waypoints = waypoints.Length;

    }

    void Update()
    {
        controladorCerditoIaEngine.numRandom = Random.Range(0, controladorCerditoIaEngine.waypoints);
        controladorCerditoIaEngine.distance = Vector3.Distance(gameObject.transform.position, waypoints[num].transform.position);
        controladorCerditoIaEngine.controlCerditoIAEngine();
       // float dist=Vector3.Distance(gameObject.transform.position,waypoints[num].transform.position);

     
        // if(go && countdown.movement==true)
        //{
        //    if(dist>minDist)
        //    {
        //        Move();
        //    }  
        //    else
        //    {
        //        if(!rand){
        //            if(num+1==waypoints.Length)
        //            {
        //                num=0;
        //            }
        //            else
        //            {
        //                num++;
        //            }
        //        }else
        //        {
        //            num=Random.Range(0,waypoints.Length);
        //        }
        //    }
        
        //}

    }
public void Move()
{
    gameObject.transform.LookAt(waypoints[num].transform.position);
    gameObject.transform.position+=gameObject.transform.forward*speed*Time.deltaTime;
}
}