using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class S_MainBasic : MonoBehaviour
{
    public float Health;
    public GameObject HealthUI;
    public Slider HealthSlider;

    // Start is called before the first frame update
    void Start()
    {
        Health = 100;
        HealthSlider.value = Health;
    }

    // Update is called once per frame
    void Update()
    {
        HealthSlider.value = Health;

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
        }
    }
}
