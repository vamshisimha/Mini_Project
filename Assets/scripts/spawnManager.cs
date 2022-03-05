using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawnRange = 9.0f;
    public int enemyCount;
    public int waveNumber=1;
    public GameObject powerUpPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(powerUpPrefab, generateSpawnPosition(), powerUpPrefab.transform.rotation);
        EnemyWave(waveNumber);
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;
        {
            if(enemyCount == 0)
            {
                waveNumber++;
                EnemyWave(waveNumber);
                Instantiate(powerUpPrefab, generateSpawnPosition(), powerUpPrefab.transform.rotation);
            }
        }

    }
    private Vector3 generateSpawnPosition()
    {
        float spawnX = Random.Range(-spawnRange, spawnRange);
        float spawnZ = Random.Range(-spawnRange, spawnRange);
        Vector3 spawnPos = new Vector3(spawnX, 0, spawnZ);
        return spawnPos;
    }
    void EnemyWave(int enemyToSpawn)
    {
        for(int i=0;i< enemyToSpawn; i++)
        {
            Instantiate(enemyPrefab, generateSpawnPosition(), enemyPrefab.transform.rotation);
        }
    }
}
