using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Spawner : MonoBehaviour
{
    [SerializeField] GameObject EnemyPrefab;
    [SerializeField] GameObject Low_Poli_Enemy_Prefab;
    [SerializeField] GameObject BOSS;
    [SerializeField] float minDelay;
    [SerializeField] float MaxDelay;
    Transform SpawnVolume;
    Script_SpawnManager SpawnMana;
    Vector3 CenterPos;
    float MaxXPos;
    float MaxZPos;

    // Start is called before the first frame update
    void Start()
    {
        SpawnVolume = transform.GetChild(0);
        CenterPos = new Vector3(SpawnVolume.position.x, SpawnVolume.position.y - SpawnVolume.localScale.y/2, SpawnVolume.position.z);
        MaxXPos = SpawnVolume.localScale.x/2;
        MaxZPos = SpawnVolume.localScale.z/2;
        Destroy(SpawnVolume.gameObject);
        SpawnMana = FindObjectOfType<Script_SpawnManager>();
        StartCoroutine(SpawnEnemy());
    }

    IEnumerator SpawnEnemy()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minDelay, MaxDelay));
            Vector3 Pos = new Vector3(Random.Range(-MaxXPos, MaxXPos), 0.0f, Random.Range(-MaxZPos, MaxZPos));
            int enemyRand = Random.Range(1, 4);
            Debug.Log(enemyRand);

            if (enemyRand == 1)
            {
                Instantiate(EnemyPrefab, CenterPos + Pos, new Quaternion());
            }
            else if (enemyRand == 2)
            {
                Instantiate(Low_Poli_Enemy_Prefab, CenterPos + Pos, new Quaternion());
            }
            else
            {
                Instantiate(BOSS, CenterPos + Pos, new Quaternion());
            }


            
        }
        
    }
}
