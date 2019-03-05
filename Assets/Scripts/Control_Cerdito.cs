﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Control_Cerdito : MonoBehaviour
{
    public ControlCerditoEngine controlCerditoEngine=new ControlCerditoEngine();
    public ItemControl itemControl;
    public Countdown countdown;

    public Text TextSpeed;
    public WheelCollider Front_Left;
    public WheelCollider Front_Right;
    public WheelCollider Back_Left;
    public WheelCollider Back_Right;
    public float Torque;
    public float Speed;
    public float MaxSpeed=200f;
    public int Brake=10000;
    public float CoefAccelaration=10f;
    public float WheelAngleMax=5;
    public bool activeItem;
    public int numRandom;
    public Rigidbody Cerdito;
    //public object Cerdito2;
    private Animator animacion; //hola

    void Start()
    {
        controlCerditoEngine.frontRightMotor = Front_Right.motorTorque;
        controlCerditoEngine.frontRightBrake = Front_Right.brakeTorque;
        controlCerditoEngine.frontLeftMotor = Front_Left.motorTorque;
        controlCerditoEngine.frontLeftBrake = Front_Left.brakeTorque;
        controlCerditoEngine.backRightBrake = Back_Right.brakeTorque;
        controlCerditoEngine.backRightMotor = Back_Right.motorTorque;
        controlCerditoEngine.backLeftBrake = Back_Left.brakeTorque;
        controlCerditoEngine.backLeftMotor = Back_Left.motorTorque;


        controlCerditoEngine.torqueEngine = Torque;
        controlCerditoEngine.coefAceleration = CoefAccelaration;
        controlCerditoEngine.time = Time.deltaTime;
        controlCerditoEngine.brake = Brake;
        controlCerditoEngine.wheelAngleMax = WheelAngleMax;
        controlCerditoEngine.buttonAxisVertical = Input.GetAxis("Vertical");
        controlCerditoEngine.buttonAxisHorizontal = Input.GetAxis("Horizontal");


        activeItem = false;
        itemControl = FindObjectOfType<ItemControl>();
        Cerdito.centerOfMass=new Vector3(0,.3f,0);
        //Cerdito2.centerOfMass=new Vector3(0,-1,0);
        //animaciones abajito
        animacion = GetComponentInChildren<Animator>();
        animacioncorrer();
        animacion.SetBool("frenado", false);
        animacion.SetBool("iddle2", false); //hola
    }

    private void animacioncorrer()
    {
        animacion.SetBool("correr", false);
    }

    // Update is called once per frame
    void Update()
    {
        float Girar=Input.GetAxis("Horizontal");

        //VISUALIZATION OF SPEED
        Speed=GetComponent<Rigidbody>().velocity.magnitude*3.6f;
        TextSpeed.text ="Velocidad: "+(int)Speed+" KM/HR";
        Debug.Log("triggers: " + Input.GetAxis("P1 Triggers"));

        //ACCERELATION
        if(Input.GetKey(KeyCode.UpArrow) && Speed<MaxSpeed && countdown.movement==true  )
        {

            controlCerditoEngine.aceleration();
            //controlCerditoEngine.aceleration(Back_Left.brakeTorque, Back_Right.brakeTorque, Back_Left.motorTorque,
            //    Back_Right.motorTorque, Front_Left.brakeTorque, Front_Right.brakeTorque, Front_Left.motorTorque, Front_Right.motorTorque);

            //Back_Left.brakeTorque=0;

            //Back_Left.brakeTorque=0;
            //Back_Right.brakeTorque=0;
            //Back_Left.motorTorque=Input.GetAxis("Vertical")*Torque*CoefAccelaration*Time.deltaTime;
            //Back_Right.motorTorque=Input.GetAxis("Vertical")*Torque*CoefAccelaration*Time.deltaTime;
            //Front_Left.brakeTorque=0;
            //Front_Right.brakeTorque=0;
            //Front_Left.motorTorque=Input.GetAxis("Vertical")*Torque*CoefAccelaration*Time.deltaTime;
            //Front_Right.motorTorque=Input.GetAxis("Vertical")*Torque*CoefAccelaration*Time.deltaTime;

            animacion.SetBool("correr", true); //hola
        }

        //REVERSA
        
        if(Input.GetKey(KeyCode.DownArrow)&& countdown.movement==true  )
        {

            controlCerditoEngine.reverse();


            //Back_Left.brakeTorque=0;
            //Back_Right.brakeTorque=0;
            //Back_Left.motorTorque=Input.GetAxis("Vertical")*Torque*CoefAccelaration*Time.deltaTime;
            //Back_Right.motorTorque=Input.GetAxis("Vertical")*Torque*CoefAccelaration*Time.deltaTime;
            //Front_Left.brakeTorque=0;
            //Front_Right.brakeTorque=0;
            //Front_Left.motorTorque=Input.GetAxis("Vertical")*Torque*CoefAccelaration*Time.deltaTime;
            //Front_Right.motorTorque=Input.GetAxis("Vertical")*Torque*CoefAccelaration*Time.deltaTime;
            ////Debug.Log(Input.GetAxis("Vertical"));
            //Debug.Log(Front_Left.motorTorque);
            //Debug.Log(Front_Right.motorTorque);
            //Debug.Log(Back_Left.motorTorque);
            //Debug.Log(Back_Right.motorTorque);
            //Debug.Log(Input.GetAxis(KeyCode.UpArrow));
        }
         
        //DECELERATION

        
        if(Input.GetKeyUp(KeyCode.UpArrow) || Speed>MaxSpeed || Input.GetKeyUp(KeyCode.DownArrow))
        {

            controlCerditoEngine.reverse();
            //Back_Left.brakeTorque=0;
            //Back_Right.brakeTorque=0;
            //Back_Left.brakeTorque=Brake*CoefAccelaration*Time.deltaTime;
            //Back_Right.brakeTorque=Brake*CoefAccelaration*Time.deltaTime;


            //Front_Left.brakeTorque=0;
            //Front_Right.brakeTorque=0;
            //Front_Left.brakeTorque=Brake*CoefAccelaration*Time.deltaTime;
            //Front_Right.brakeTorque=Brake*CoefAccelaration*Time.deltaTime;

            if (!Input.GetKey(KeyCode.UpArrow) && (Speed > 1 ) )//hola para activar frenado 
            {
                animacioncorrer();
                animacion.SetBool("iddle2", false);
                animacion.SetBool("frenado", true); //hola

            }
            else
            {
                animacioncorrer();
                animacion.SetBool("frenado", false); //hola
                animacion.SetBool("iddle2", true);
            }
        }
        
        

        //Direction of the pig
        controlCerditoEngine.turn();
        //Front_Left.steerAngle=Input.GetAxis("Horizontal")*WheelAngleMax;
        //Front_Right.steerAngle=Input.GetAxis("Horizontal")*WheelAngleMax;

        if (Speed>2)
        {
   
            if (Girar<0){
                Cerdito.transform.Rotate(0,-1.75f,0);
                
            }

            if(Girar>0){
                Cerdito.transform.Rotate(0,1.75f,0);
            }
        }
        //if(Girar==0){
        //Cerdito.transform.Rotate(0,0,0);
        //}
        //Debug.Log(Girar);



        //Active item
        if (Input.GetKey(KeyCode.M) && activeItem == true)
        {
            itemControl.ChargeItem(numRandom);
            activeItem = false;
        }

    }
    void OnCollisionEnter(Collision collision)
    {

        //Debug.Log(collision.gameObject.name);
        if(collision.gameObject.name=="Modulo-Inicio-Pendiente")

        {
            Torque=35000;
            MaxSpeed=160;
           // Debug.Log(Torque);

        }
        if(collision.gameObject.name=="Modulo_Recto (14)" || collision.gameObject.name == "Modulo_Recto (15)" ||
           collision.gameObject.name == "Modulo_Recto (16)"|| collision.gameObject.name == "Modulo_Recto (17)"||
           collision.gameObject.name == "Modulo_Recto (25)")
        {
            CoefAccelaration=25;
        }else
        {
            Torque=1750;
            MaxSpeed=80;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("barril"))
        {
            activeItem = true;
        }
    }
}

