using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{


    public GameObject spikePrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector2 randomSpawnPosition = new Vector2(Random.Range(-10, 11), 5);
            Instantiate(spikePrefab,randomSpawnPosition,Quaternion.identity);
        }
    }

    public void spawnspike()
    {

    }
}
