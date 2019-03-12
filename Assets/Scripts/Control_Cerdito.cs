using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Control_Cerdito : MonoBehaviour
{
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
    public Animator animacioncerdito; //hola animator del cerdito
    public Animator anicharacter; //animator del personaje


    void Start()
    {
        activeItem = false;
        itemControl = FindObjectOfType<ItemControl>();
        Cerdito.centerOfMass=new Vector3(0,.3f,0);
        //Cerdito2.centerOfMass=new Vector3(0,-1,0);
        //animaciones abajito
        
        animacioncerdito.SetInteger("cerdito", 0);
        anicharacter.SetInteger("personaje", 0);
        


    }


    IEnumerator corutinawaitfrenadoyluegocorrer()
    {
        animacioncerdito.SetInteger("cerdito", 2);
       // animacion.SetBool("frenado", true); animacion.SetBool("correr", false); animacion.SetBool("iddle2", false);
       // print("hola probando corrutina");
        yield return new WaitForSeconds(3f);
        //animacion.SetBool("frenado", false); animacion.SetBool("correr", true); animacion.SetBool("iddle2", false);
        animacioncerdito.SetInteger("cerdito", 1);
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
            Back_Left.brakeTorque=0;
            Back_Right.brakeTorque=0;
            Back_Left.motorTorque=Input.GetAxis("Vertical")*Torque*CoefAccelaration*Time.deltaTime;
            Back_Right.motorTorque=Input.GetAxis("Vertical")*Torque*CoefAccelaration*Time.deltaTime;
            Front_Left.brakeTorque=0;
            Front_Right.brakeTorque=0;
            Front_Left.motorTorque=Input.GetAxis("Vertical")*Torque*CoefAccelaration*Time.deltaTime;
            Front_Right.motorTorque=Input.GetAxis("Vertical")*Torque*CoefAccelaration*Time.deltaTime;

           
            StartCoroutine(corutinawaitfrenadoyluegocorrer());  // animacion.SetBool("correr", true); animacion.SetBool("iddle2", false); animacion.SetBool("frenado", false); //hola
                                                                // animacion_character.SetInteger("personaje", 1);
            
                
            anicharacter.SetInteger("personaje", 1);
       
        }

        //REVERSA
        
        if (Input.GetKey(KeyCode.DownArrow) && countdown.movement == true)
        {
            Back_Left.brakeTorque = 0;
            Back_Right.brakeTorque = 0;
            Back_Left.motorTorque = Input.GetAxis("Vertical") * Torque * CoefAccelaration * Time.deltaTime;
            Back_Right.motorTorque = Input.GetAxis("Vertical") * Torque * CoefAccelaration * Time.deltaTime;


            ;

            Front_Left.brakeTorque = 0;
            Front_Right.brakeTorque = 0;
            Front_Left.motorTorque = Input.GetAxis("Vertical") * Torque * CoefAccelaration * Time.deltaTime;
            Front_Right.motorTorque = Input.GetAxis("Vertical") * Torque * CoefAccelaration * Time.deltaTime;
            //Debug.Log(Input.GetAxis("Vertical"));
            Debug.Log(Front_Left.motorTorque);
            Debug.Log(Front_Right.motorTorque);
            Debug.Log(Back_Left.motorTorque);
            Debug.Log(Back_Right.motorTorque);
            //Debug.Log(Input.GetAxis(KeyCode.UpArrow));
            anicharacter.SetInteger("personaje", 4);

          /*  int randomidle = Random.Range(1, 11);//variable para generar un random para que sea diferente el idle 
            switch (randomidle)
            {
                case 1:
                    print("randomidle");

                    break;
                 default:
                    print("randomidle  default");
                    break;
            }*/
            

            StartCoroutine(corutinawaitfrenadoyluegocorrer());//para la corrutina de activar el frenado y luego correr

            
        }
         
        //DECELERATION

        
        if(Input.GetKeyUp(KeyCode.UpArrow)&&Speed>1 || Speed>MaxSpeed || Input.GetKeyUp(KeyCode.DownArrow) && Speed > 1)

        {
            
            Back_Left.brakeTorque=0;
            Back_Right.brakeTorque=0;
            Back_Left.brakeTorque=Brake*CoefAccelaration*Time.deltaTime;
            Back_Right.brakeTorque=Brake*CoefAccelaration*Time.deltaTime;
            
            
            Front_Left.brakeTorque=0;
            Front_Right.brakeTorque=0;
            Front_Left.brakeTorque=Brake*CoefAccelaration*Time.deltaTime;
            Front_Right.brakeTorque=Brake*CoefAccelaration*Time.deltaTime;

            // animacion.SetBool("correr", true); animacion.SetBool("iddle2", false); animacion.SetBool("frenado", false); //hola
            animacioncerdito.SetInteger("cerdito", 1);




        }
        if (Speed<=1)
        {
            // animacion.SetBool("correr", false); animacion.SetBool("iddle2", true); animacion.SetBool("frenado", false); //hola
            animacioncerdito.SetInteger("cerdito", 0);
            anicharacter.SetInteger("personaje", 0);
        }
        

        //Direction of the pig
        Front_Left.steerAngle=Input.GetAxis("Horizontal")*WheelAngleMax;
        Front_Right.steerAngle=Input.GetAxis("Horizontal")*WheelAngleMax;
        
        if(Speed>2)
        {
            if(Girar<0){
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
        if(collision.gameObject.name=="Modulo_Recto (14)")
        {
            CoefAccelaration=25;
        }
         if(collision.gameObject.name=="Modulo_Recto (15)")
        {
            CoefAccelaration=25;
        }
         if(collision.gameObject.name=="Modulo_Recto (16)")
        {
            CoefAccelaration=25;
        }
         if(collision.gameObject.name=="Modulo_Recto (17)")
        {
            CoefAccelaration=25;
        }
         if(collision.gameObject.name=="Modulo_Recto (25)")
        {
            CoefAccelaration=25;
        }
        
        else
        {
            Torque=1750;
            MaxSpeed=80;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("barril"))
        {
            Debug.Log("item activo");
            activeItem = true;
        }
    }
}

