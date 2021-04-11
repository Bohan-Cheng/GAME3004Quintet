using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WaveNumberDisplayer : MonoBehaviour
{
    private GameObject      SpawnerGORef;
    private Script_Spawner  SpawnerScriptRef;
    Text text;
    
    void Start()
    {
        SpawnerGORef = GameObject.FindGameObjectWithTag("Spawner");
        SpawnerScriptRef = SpawnerGORef.GetComponent<Script_Spawner>();
        text = GetComponent<Text>();
    }


    void Update()
    {
        text.text = "Wave: " + SpawnerScriptRef.waveNum.ToString();
    }
}
