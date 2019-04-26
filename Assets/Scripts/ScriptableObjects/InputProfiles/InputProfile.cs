using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "new InputProfile", menuName = "ScriptableObjects/new InputProfile", order = 1)]
public class InputProfile : ScriptableObject
{

    public KeyCode jump;

    public KeyCode powerUp;

    public string verticalAxis, horizontalAxis;

}
