using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Spawner : MonoBehaviour
{
    [SerializeField] GameObject EnemyPrefab;
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
        //Destroy(SpawnVolume.gameObject);
        SpawnMana = FindObjectOfType<Script_SpawnManager>();
        StartCoroutine(SpawnEnemy());
    }

    IEnumerator SpawnEnemy()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minDelay, MaxDelay));
            Vector3 Pos = new Vector3(Random.Range(-MaxXPos, MaxXPos), 0.0f, Random.Range(-MaxZPos, MaxZPos));
            Instantiate(EnemyPrefab, CenterPos + Pos, new Quaternion());
        }
        
    }
}
