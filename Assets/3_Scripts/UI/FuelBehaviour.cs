using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelBehaviour : MonoBehaviour
{
    public static float fuelNumber = 500f;
    public Text fuel;

    private void Start()
    {
        fuel = GetComponent<Text>();
    }

    private void Update()
    {
        if(fuelNumber <= 0)
        {
            print("Lights out!");
        }

        ReduceFuel();
        fuel.text = "" + fuelNumber;
    }

    void ReduceFuel()
    {
        fuelNumber -= Time.deltaTime;
    }
}
