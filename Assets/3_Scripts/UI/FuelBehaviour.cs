using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelBehaviour : MonoBehaviour
{
    public static int fuelNumber = 100;
    public Text fuel;

    private void Start()
    {
        fuel = GetComponent<Text>();
    }

    private void Update()
    {
        if(fuelNumber <= 0)
        {
            fuelNumber = 100;
        }
        fuel.text = "" + fuelNumber;
    }
}
