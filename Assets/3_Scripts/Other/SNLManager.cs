using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SNLManager : MonoBehaviour
{
    [SerializeField]
    private LevelState level;

    public static SNLManager instance;


    //public int curWave;
    [SerializeField]
    public GameObject spawner;
    public Script_Spawner spawnerScript;

    private void Start()
    {
        spawnerScript = spawner.GetComponent<Script_Spawner>();
    }

    public void Save()
    {
        level.currentWave = spawnerScript.waveNum;
        
    }

    public void Load()
    {
        GameObject[] spawners = GameObject.FindGameObjectsWithTag("Spawner");
        for (int i = 0; i < spawners.Length; i++)
        {
            Script_Spawner tempScriptRef = spawners[i].GetComponent<Script_Spawner>();
            tempScriptRef.waveNum = level.currentWave;
        }
    }

}
