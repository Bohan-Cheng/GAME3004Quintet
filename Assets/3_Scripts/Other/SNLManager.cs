using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SNLManager : MonoBehaviour
{
    [SerializeField]
    private LevelState level;

    public GameObject[] allEnemies;
    public GameObject[] allTurrets;
    public GameObject[] fullArray;

    [SerializeField]
    public GameObject turretPrefab;
    public GameObject enemyPrefab;

    private void Start()
    {

    }



    public void Save()
    {
        if(GameObject.FindGameObjectsWithTag("Enemy").Length > 0)
        {
            allEnemies = GameObject.FindGameObjectsWithTag("Enemy");
            Debug.Log("saved enemies: " + GameObject.FindGameObjectsWithTag("Enemy").Length);
        }


        if (GameObject.FindGameObjectsWithTag("Turret").Length > 0)
        {
            allTurrets = GameObject.FindGameObjectsWithTag("Turret");
            Debug.Log("saved turrets" + GameObject.FindGameObjectsWithTag("Turret").Length);
        }


        for (int i = 0; i < allEnemies.Length; i++)
        {
            fullArray[i] = allEnemies[i];
        }

        for (int i = 0; i < allTurrets.Length; i++)
        {
            fullArray[i] = allTurrets[i];
        }

        level.enemies = allEnemies;
        level.turrets = allTurrets;

    }


    public void Load()
    {
        DestroyAllDynamicObjects();
        SpawnAllDynamicObjects();
    }

    private void DestroyAllDynamicObjects()
    {
        for (int i = 0; i < GameObject.FindGameObjectsWithTag("Enemy").Length; i++)
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemy"));
        }

        for (int i = 0; i < GameObject.FindGameObjectsWithTag("Turret").Length; i++)
        {
            Destroy(GameObject.FindGameObjectWithTag("Turret"));
        }
    }

    void SpawnAllDynamicObjects()
    {
        for (int i = 0; i < level.enemies.Length; i++)
        {
            GameObject tempEnemy = Instantiate(level.enemies[i], level.enemies[i].transform.position, level.enemies[i].transform.rotation);
        }

        for (int i = 0; i < level.turrets.Length; i++)
        {
            GameObject tempTurret = Instantiate(level.enemies[i], level.enemies[i].transform.position, level.enemies[i].transform.rotation);
        }
    }
}
