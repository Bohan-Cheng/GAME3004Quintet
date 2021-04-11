using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WaveDelayDisplayer : MonoBehaviour
{
    private Text text;
    private float remainingTime;
    private bool timerActive;
    private int numberOfSpawnersTriggeredIt;

    // Start is called before the first frame update
    void Start()
    {
        numberOfSpawnersTriggeredIt = 0;
        timerActive = false;
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(timerActive)
        {
            if (remainingTime > 0)
            {
                text.text = "Time until next wave: " + remainingTime;
                remainingTime -= Time.deltaTime;

            }
            else
            {
                remainingTime = 0.0f;
                timerActive = false;
            }

        }
        else
        {
            text.text = "";
        }


    }


    public void TriggerTimerDisplay(float time)
    {
        numberOfSpawnersTriggeredIt++;
        if (numberOfSpawnersTriggeredIt >= GameObject.FindGameObjectsWithTag("Spawner").Length)
        timerActive = true;

        remainingTime = time;
    }
}
