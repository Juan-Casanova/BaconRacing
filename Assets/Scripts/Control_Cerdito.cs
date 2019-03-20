using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Control_Cerdito : MonoBehaviour
{
    public MostrarItem mostrarItem;
   public ItemControl itemControl;
    public Countdown countdown;

    public AudioSource tickSource;
    
    public Text TextSpeed;
    public WheelCollider Front_Left;
    public WheelCollider Front_Right;
    public WheelCollider Back_Left;
    public WheelCollider Back_Right;
    public float Torque;
    public float Speed;
    public float MaxSpeed=200;
    public int Brake= 10000;
    public float CoefAccelaration=10;
    public float WheelAngleMax=5;
    public bool activeItem=false;
    public int numRandom;
    public Rigidbody Cerdito;
    //public object Cerdito2;
    public Animator animacioncerdito; //hola animator del cerdito
    public Animator anicharacter; //animator del personaje
    int randomidle;//variable para generar un random para que sea diferente el idle 

    public bool superSalto=false;

    void Start()
    {
        tickSource = GetComponent<AudioSource>();
        

        itemControl = FindObjectOfType<ItemControl>();
        Cerdito.centerOfMass=new Vector3(0,.3f,0);
        //Cerdito2.centerOfMass=new Vector3(0,-1,0);
        //animaciones abajito
        animacioncerdito.SetInteger("cerdito", 0);
        anicharacter.SetInteger("personaje", 0);
        Debug.Log(randomidle);
        randomidle = Random.Range(1, 13);
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
        float Girar=Input.GetAxis("Horizontal");//

        //VISUALIZATION OF SPEED
        Speed=GetComponent<Rigidbody>().velocity.magnitude*3.6f;
        TextSpeed.text ="Velocidad: "+(int)Speed+" KM/HR";
        Debug.Log("triggers: " + Input.GetAxis("P1 Triggers"));
        //ACCERELATION
        if (Input.GetKey(KeyCode.UpArrow) && Speed < MaxSpeed && countdown.movement == true)
        {
            Back_Left.brakeTorque = 0;
            Back_Right.brakeTorque = 0;
            Back_Left.motorTorque = Input.GetAxis("Vertical") * Torque * CoefAccelaration * Time.deltaTime;
            Back_Right.motorTorque = Input.GetAxis("Vertical") * Torque * CoefAccelaration * Time.deltaTime;
            Front_Left.brakeTorque = 0;
            Front_Right.brakeTorque = 0;
            Front_Left.motorTorque = Input.GetAxis("Vertical") * Torque * CoefAccelaration * Time.deltaTime;
            Front_Right.motorTorque = Input.GetAxis("Vertical") * Torque * CoefAccelaration * Time.deltaTime;

            StartCoroutine(corutinawaitfrenadoyluegocorrer());  // animacion.SetBool("correr", true); animacion.SetBool("iddle2", false); animacion.SetBool("frenado", false); //hola
                                                                // animacion_character.SetInteger("personaje", 1);


            anicharacter.SetInteger("personaje", 1);

        }

        //REVERSA

        if (Input.GetKey(KeyCode.DownArrow)&& countdown.movement==true  )
        {
            Back_Left.brakeTorque=0;
            Back_Right.brakeTorque=0;
            Back_Left.motorTorque=Input.GetAxis("Vertical")*Torque*CoefAccelaration*Time.deltaTime;
            Back_Right.motorTorque=Input.GetAxis("Vertical")*Torque*CoefAccelaration*Time.deltaTime;

            
            
            
            Front_Left.brakeTorque=0;
            Front_Right.brakeTorque=0;
            Front_Left.motorTorque=Input.GetAxis("Vertical")*Torque*CoefAccelaration*Time.deltaTime;
            Front_Right.motorTorque=Input.GetAxis("Vertical")*Torque*CoefAccelaration*Time.deltaTime;

            //anicharacter.SetInteger("personaje", 1);//probajndo daño
           // StartCoroutine(corutinawaitfrenadoyluegocorrer());
        }

        //DECELERATION


        if (Input.GetKeyUp(KeyCode.UpArrow) && Speed > 1 || Speed > MaxSpeed || Input.GetKeyUp(KeyCode.DownArrow) && Speed > 1)

        {
            Back_Left.brakeTorque=0;
            Back_Right.brakeTorque=0;
            Back_Left.brakeTorque=Brake*CoefAccelaration*Time.deltaTime;
            Back_Right.brakeTorque=Brake*CoefAccelaration*Time.deltaTime;
            
            
            Front_Left.brakeTorque=0;
            Front_Right.brakeTorque=0;
            Front_Left.brakeTorque=Brake*CoefAccelaration*Time.deltaTime;
            Front_Right.brakeTorque=Brake*CoefAccelaration*Time.deltaTime;

            animacioncerdito.SetInteger("cerdito", 1);

            
        }
        if (Speed <= 1)
        {

            //  animacioncerdito.SetInteger("cerdito", 0);
            anicharacter.SetInteger("personaje", 0);



            if (randomidle <= 6) //Para el random de 2 idles que habra
            { animacioncerdito.SetInteger("cerdito", 1); Debug.Log("menora5"); }
            else { Debug.Log("mayor as 5"); animacioncerdito.SetInteger("cerdito", 1); }

        }



        //Direction of the pig
        Front_Left.steerAngle=Input.GetAxis("Horizontal")*WheelAngleMax;
        Front_Right.steerAngle=Input.GetAxis("Horizontal")*WheelAngleMax;
        
        if(Speed>2)
        {
            if(Input.GetKey(KeyCode.LeftArrow)){
                Cerdito.transform.Rotate(0,-1.75f,0);
                
            }

            if(Input.GetKey(KeyCode.RightArrow)){
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
                mostrarItem.desactivarIconosItems();
                activeItem = false;
            }
                
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(superSalto)
            {
               // Cerdito.transform.Translate(0,Time.deltaTime*1500,Time.deltaTime*2500);
               Cerdito.transform.Translate(0,40,60);              
            }
            else
            {
                Cerdito.transform.Translate(0,4,0);                   
            }
        }
       
 
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name=="Modulo_recto (3)"||collision.gameObject.name=="Modulo inicio de pendiente"
         ||collision.gameObject.name=="Modulo_Recto (14)"||collision.gameObject.name=="Modulo_Recto (15)"||
         collision.gameObject.name=="Modulo_Recto (16)"||collision.gameObject.name=="Modulo_Recto (17)"||
         collision.gameObject.name=="Modulo_Recto (25)")

        {
            Front_Left.motorTorque=25000;
            Front_Right.motorTorque=25000;
            Back_Left.motorTorque=25000;
            Back_Right.motorTorque=25000;
            //MaxSpeed=80;
            Torque=3500;
            CoefAccelaration=100;
            superSalto=true;
            

        }

        if(collision.gameObject.name=="Modulo curva ascendente (1)")
        {
            Front_Left.motorTorque=25000;
            Front_Right.motorTorque=25000;
            Back_Left.motorTorque=25000;
            Back_Right.motorTorque=25000;
            Debug.Log(Front_Left.motorTorque);
            CoefAccelaration=1000;
        }
        //if(!collision.gameObject.name=="Modulo_recto (3)"||!collision.gameObject.name=="Modulo inicio de pendiente"
        //||!collision.gameObject.name=="Modulo_Recto (14)"||!collision.gameObject.name=="Modulo_Recto (15)"||
         //!collision.gameObject.name=="Modulo_Recto (16)"||!collision.gameObject.name=="Modulo_Recto (17)"||
         //!collision.gameObject.name=="Modulo_Recto (25)")
         else
        {
            Torque=1750;
            MaxSpeed=60;
            superSalto=false;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("barril"))
        {
            numRandom=itemControl.getItemRandom();
            mostrarItem.ShowItem(numRandom);
            Debug.Log("MostrarItem"+numRandom);
            activeItem = true;
        }
        if (other.gameObject.tag == "barril")
        {

            tickSource.Play();
        }
        
    }
}

