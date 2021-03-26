using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_ItemInfo : MonoBehaviour
{
    [SerializeField] int Cost = 350;

    // Start is called before the first frame update
    void Start()
    {
        if(!EnoughForItem())
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BuyItem()
    {
        ResourceCounter.resourceNumber -= Cost;
    }

    bool EnoughForItem()
    {
        return ResourceCounter.resourceNumber >= Cost;
    }
}
