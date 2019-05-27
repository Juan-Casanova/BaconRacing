using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class ControlLogin : MonoBehaviour
{
    public Canvas Login;
    public Canvas Registro;
    public InputField Entrar_Usuario;
    public InputField Entrar_Contraseña;
    public InputField Registrar_Usuario;
    public InputField Registrar_Contraseña;
    public Text LlenarCampos;
    public Text VolverIntentar;
    string UsuarioPro;
    string ContraseñaPro;
    string UsuarioIngre;
    string ContraseñaIngre;

    private string rutaArchivo;

    static bool PrimeraVez=true;

    void Awake()
    {
        rutaArchivo = Application.persistentDataPath + "/datos.data";
        if (PrimeraVez)
        {
            Cargar();
            PrimeraVez = false;
        }
    }

    public void OcultarLoginYActivarRegistro()
    {
        Login.enabled = false;
        Registro.enabled = true;
    }
    public void OcultarRegistroYActivarLogin()
    {
        Login.enabled = true;
        Registro.enabled = false;
    }

    public void A()
    {
        UsuarioPro = Registrar_Usuario.text;
        ContraseñaPro = Registrar_Contraseña.text;
        //UsuarioPro = UsuarioPro.ToUpper();
        //ContraseñaPro = ContraseñaPro.ToUpper();
    }

    public void Guardar()
    {
        A();
        if (UsuarioPro == "" || ContraseñaPro == "")
        {
            LlenarCampos.gameObject.SetActive(true);
        }
        else
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Create(rutaArchivo);
            DatosAGuardar datos = new DatosAGuardar(UsuarioPro,ContraseñaPro);
            bf.Serialize(file,datos);
            file.Close();
        }
        OcultarRegistroYActivarLogin();
    }

    public void Cargar()
    {
        if (File.Exists(rutaArchivo))
        {
            BinaryFormatter bf=new BinaryFormatter();
            FileStream file = File.Open(rutaArchivo, FileMode.Open);
            DatosAGuardar datos = (DatosAGuardar) bf.Deserialize(file);
            UsuarioPro = datos.Usuario;
            ContraseñaPro = datos.Contraseña;
            //Debug.Log("hayarchivo");
            Debug.Log(UsuarioPro);
            Debug.Log(ContraseñaPro);
        }
        else
        {
            UsuarioPro = "a";
            ContraseñaPro = "a";
           // Debug.Log("es esto");
        }

        ComprobarLogin();
    }

    void ComprobarLogin()
    {
        UsuarioIngre = Entrar_Usuario.text;
        ContraseñaIngre = Entrar_Contraseña.text;
        //UsuarioIngre = UsuarioIngre.ToUpper();
        //ContraseñaIngre = ContraseñaIngre.ToUpper();
        if (UsuarioPro == UsuarioIngre && ContraseñaPro == ContraseñaIngre)
        {
            SceneManager.LoadScene("Menu_Principal");
        }
        else
        {
            VolverIntentar.gameObject.SetActive(true);
        }
    }
}

[System.Serializable]
class DatosAGuardar
{
    public string Usuario;
    public string Contraseña;

    public DatosAGuardar(string Usuario_, string Contraseña_)
    {
        Usuario = Usuario_;
        Contraseña = Contraseña_;
    }
}
