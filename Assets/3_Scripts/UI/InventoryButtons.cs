using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryButtons : MonoBehaviour
{
   

    private void Start()
    {
        
    }
    public void OnSlot1Clicked()
    {
        Debug.Log("Slot clicked.");
        FuelBehaviour.fuelNumber -= 7;
    }

    public void OnSlot2Clicked()
    {

    }
  
}
