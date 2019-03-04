﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SocialPlatforms;

public class Controlado_Cerdo_IA: MonoBehaviour
{
    public Countdown countdown;

    public GameObject[] waypoints;
    public int num=0;

    public float minDist;
    public float speed;

    public bool rand=false;
    public bool go =true;
    void Update(){
        float dist=Vector3.Distance(gameObject.transform.position,waypoints[num].transform.position);

     
         if(go && countdown.movement==true)
        {
            if(dist>minDist)
            {
                Move();
            }  
            else
            {
                if(!rand){
                    if(num+1==waypoints.Length)
                    {
                        num=0;
                    }
                    else
                    {
                        num++;
                    }
                }else
                {
                    num=Random.Range(0,waypoints.Length);
                }
            }
        
        }

   }
public void Move()
{
    gameObject.transform.LookAt(waypoints[num].transform.position);
    gameObject.transform.position+=gameObject.transform.forward*speed*Time.deltaTime;
}
}