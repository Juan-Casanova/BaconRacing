using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour, IMeta
{


    public static GameManager instancia;

    public GameObject player1Prefab, player2Prefab;
    public GameObject player1Instancia, player2Instancia;


    public GameObject SrTequilaP1, SrTequilaP2;
    public GameObject SakeP1, SakeP2;
    public GameObject CuauhtemocP1, CuauhtemocP2;
    public GameObject MecaTequilaP1, MecaTequilaP2, MecaSakeP1, MecaSakeP2, MecaCuahuP1, MecaCuahuP2, QuetzalSakeP1, QuetzalSakeP2, QuetzalTequilaP1, QuetzalTequilaP2, QuetzalCuahuP1, QuetzalCuahuP2;

    void Awake()
    {
        

        if (instancia == null)
        {
            instancia = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
        }

    }

    //este no se puede probar
    public void GameOver(GameObject winner)
    {   
        if(winner == player1Instancia)
        {
            managerHUD.instancia.ShowGameResults(numPlayer.p1);
        }
        else
        {
            managerHUD.instancia.ShowGameResults(numPlayer.p2);
        }

        Time.timeScale = 0.01f;
        StartCoroutine(changeNextTrack("Menu_Principal"));

    }

    private IEnumerator changeNextTrack(string nextTrack)
    {
        
        yield return new WaitForSecondsRealtime(8);
        
        SceneManager.LoadScene(nextTrack, LoadSceneMode.Single);

    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            StopAllCoroutines();
        }
    }

    //no se puede probar
    public void PickCharacterSrTequilaP1() => player1Prefab = SrTequilaP1;

    public void PickCharacterSrTequilaP2() => player2Prefab = SrTequilaP2;

    public void PickCharacterSakeP1() => player1Prefab = SakeP1;

    public void PickCharacterSakeP2() => player2Prefab = SakeP2;

    public void PickCharacterCuauhtemocP1() => player1Prefab = CuauhtemocP1;

    public void PickCharacterCuauhtemocP2() => player2Prefab = CuauhtemocP2;

    public void PickCharacterMecaTequilaP1() => player1Prefab = MecaTequilaP1;

    public void PickCharacterMecaTequilaP2() => player2Prefab = MecaTequilaP2;

    public void PickCharacterMecaSakeP1() => player1Prefab = MecaSakeP1;

    public void PickCharacterMecaSakeP2() => player2Prefab = MecaSakeP2;

    public void PickCharacterMecaCuahuP1() => player1Prefab = MecaCuahuP1;

    public void PickCharacterMecaCuahuP2() => player2Prefab = MecaCuahuP2;


    public void PickCharacterQuetzalTequilaP1() => player1Prefab = QuetzalTequilaP1;

    public void PickCharacterQuetzalTequilaP2() => player2Prefab = QuetzalTequilaP2;

    public void PickCharacterQuetzalSakeP1() => player1Prefab = QuetzalSakeP1;

    public void PickCharacterQuetzalSakeP2() => player2Prefab = QuetzalSakeP2;

    public void PickCharacterQuetzalCuahuP1() => player1Prefab= QuetzalCuahuP1;

    public void PickCharacterQuetzalCuahuP2() => player2Prefab = QuetzalCuahuP2;
}
