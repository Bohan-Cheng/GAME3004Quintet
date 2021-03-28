using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_ReciveDamageCol : MonoBehaviour
{
    [SerializeField] Turret turretScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            other.GetComponent<Enemy>().DoAttack();
        }
    }
}
