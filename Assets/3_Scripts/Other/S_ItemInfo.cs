using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_ItemInfo : MonoBehaviour
{
    [SerializeField] int Cost = 350;
    [SerializeField] int EnergyCost = 8;
    public bool HasPower = false;


    // Start is called before the first frame update
    void Start()
    {
        if(!EnoughForItem() || !FuelBehaviour.UsePower(EnergyCost))
        {
            Destroy(gameObject);
        }
        if(!EnoughForItem())
        {
            Debug.Log("Not enough resources to build this item.");
        }
        else if(!FuelBehaviour.UsePower(EnergyCost))
        {
            Debug.Log("Not enough power to operate this item.");
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void BuyItem()
    {
        ResourceCounter.resourceNumber -= Cost;
        FuelBehaviour.Electricity -= EnergyCost;
        HasPower = true;
    }

    bool EnoughForItem()
    {
        return ResourceCounter.resourceNumber >= Cost;
    }
}
