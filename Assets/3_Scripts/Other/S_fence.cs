using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_fence : MonoBehaviour
{
    public float fenceHealth;
    public bool fenceAlive = true;
    public float attackDelay;
    GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        fenceHealth = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (fenceHealth <= 0)
        {
            enemy.GetComponent<Enemy>().StopAttack();
            Destroy(gameObject);
            fenceAlive = false;
        }
    }

    IEnumerator GetDamage()
    {
        while (fenceAlive == true)
        {
            fenceHealth -= 1;
            yield return new WaitForSeconds(2);
        }
    }

    //public void OnTriggerEnter(Collider other)
    //{
    //    if (other.tag == "Enemy")
    //    {
    //        other.GetComponent<Enemy>().DoAttack();
    //        StartCoroutine((IEnumerator)WaitForSeconds());
    //        fenceHealth = (fenceHealth - 1);
    //    }
    //}


    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            enemy = other.gameObject;
            other.GetComponent<Enemy>().DoAttack();
            StartCoroutine(GetDamage());
        }
    }


}
