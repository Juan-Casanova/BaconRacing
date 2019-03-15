using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    
    public  string nameNextScene;

    public string defineNextScene()
    {
        switch (nameNextScene)
        {
            case "Esccena_Dios":
                nameNextScene = "Loading";
                break;
            case "Loading":
                nameNextScene = "Pista_China";
                break;
            case "Pista_China":
                nameNextScene = "Esccena_Dios";
                break;
        }

        return nameNextScene;
    }

    public void changeScene()
    {
        SceneManager.LoadScene(nameNextScene);
    }

    public void Start()
    {
        defineNextScene();
    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            SceneManager.LoadScene("Loading");
           // changeScene();
        }
    }
}
