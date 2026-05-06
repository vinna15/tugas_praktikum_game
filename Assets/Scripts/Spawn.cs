using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform spawnPoint;
    public Transform playerPosition;

    [Header("Spawn Settings")]
    public float spawnDelay = 2f;
    public float spawnInterval = 3f;
    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    void SpawnEnemy()
    {
        Vector2 direction = new Vector2(playerPosition.position.x + 5, playerPosition.position.y + 10);
        Instantiate(enemyPrefab, direction, Quaternion.identity);
    }
}
