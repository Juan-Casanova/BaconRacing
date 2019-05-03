using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterList : MonoBehaviour
{
    public GameObject SrTequilaP1, StTequilaP2, CuauhtemocP1,CuauhtemocP2;

    private GameManager _gameManager;

    private void Awake()
    {
         _gameManager = new GameManager();
    }

    public void PickSrTequilaP1()
    {
        _gameManager.player1Prefab = SrTequilaP1;
    }

}
