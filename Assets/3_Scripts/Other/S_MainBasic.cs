using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class S_MainBasic : MonoBehaviour
{
    public float Health;

    // Start is called before the first frame update
    void Start()
    {
        Health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (Health <= 0)
        {
            SceneManager.LoadScene("Map_Gameover");
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            other.GetComponent<Enemy>().Die();
            Health -= 10;
            Debug.Log(Health);
        }
    }
}
