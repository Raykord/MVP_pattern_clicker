using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Player Data", menuName = "Scriptable objects/Player/Data")]
public class PlayerData : ScriptableObject
{
    public string playerName;
    public int score;
}
