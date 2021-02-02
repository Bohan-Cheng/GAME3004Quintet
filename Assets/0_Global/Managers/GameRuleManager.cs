using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRuleManager : MonoBehaviour
{
    private static GameRuleManager instance;
    //public static GameRuleManager Instance { get { return instance; } }
    public uint CurrentDay;
    public uint Score;
    public bool IsLost;
    List<GameObject> Enemies = new List<GameObject>();
    List<GameObject> Turrets = new List<GameObject>();

    private void Awake()
    {
        if (instance)   { Destroy(gameObject); }
        else            { instance = this;     }
    }
}
