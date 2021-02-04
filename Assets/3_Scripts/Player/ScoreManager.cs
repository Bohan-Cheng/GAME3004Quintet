using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static int playerScore;
    public static float fuelValue,
                        woodValue,
                        stoneValue;
    public static int playerHealthPoints;

    // Start is called before the first frame update
    void Start()
    {
        fuelValue = 50f;
        woodValue = 0f;
        stoneValue = 0f;
        playerHealthPoints = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
