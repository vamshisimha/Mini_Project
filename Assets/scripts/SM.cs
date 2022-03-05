using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SM : MonoBehaviour
{
    public GameObject[] AnimalPrefabs;
    int SpawnPosX = 20;
    int SpawnPosZ = 20;
    float StartDelay = 2.0f;
    float SpawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", StartDelay, SpawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnRandomAnimal()
    {
        int AnimalIndex = Random.Range(0, AnimalPrefabs.Length);
        Vector3 SpawnPos = new Vector3(Random.Range(-SpawnPosX, SpawnPosX), 0, SpawnPosZ);
        Instantiate(AnimalPrefabs[AnimalIndex], SpawnPos, AnimalPrefabs[AnimalIndex].transform.rotation);
    }
}
