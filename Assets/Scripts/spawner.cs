using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public float SpawningRate = 2f;
    public GameObject EnemyPrefab;
    public playerMov Player;
    public Transform[] SpawnPoints;

    private float LastSpawnTime;

    void Update()
    {
        if (Player == null) return;

        if (LastSpawnTime + SpawningRate < Time.time)
        {
            var randomSpawnPoint = SpawnPoints[Random.Range(0, SpawnPoints.Length)];
            
            Instantiate(EnemyPrefab, randomSpawnPoint.position, Quaternion.identity);
            LastSpawnTime = Time.time;
            SpawningRate *= 0.98f;
        }
    }
}
