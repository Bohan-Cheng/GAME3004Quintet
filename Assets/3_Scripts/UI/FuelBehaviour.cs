using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelBehaviour : MonoBehaviour
{
    public static int Electricity = 10;
    public Text ElectricityText;

    private void Start()
    {
        ElectricityText = GetComponent<Text>();
    }

    private void Update()
    {
        if(Electricity <= 0)
        {
            print("Lights out!");
        }

        ReduceFuel();
        ElectricityText.text = "" + Electricity;
    }

    void ReduceFuel()
    {
        //fuelNumber -= Time.deltaTime;
    }
}
