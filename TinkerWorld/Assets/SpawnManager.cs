using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{


    public GameObject spikePrefab;

    // Update is called once per frame
    void Update()
    {
       
    }

    public void spawnspike()
    {
        Vector2 randomSpawnPosition = new Vector2(Random.Range(-10, 20), 16.4f);
        Instantiate(spikePrefab, randomSpawnPosition, Quaternion.identity);
    }
}
