using System;
using UnityEngine;


public class CloudSpawnerScript : MonoBehaviour
{
    // Settings

    // Connections

    // State Variables
    public GameObject cloudPrefab;
    public float spawnRate;
    Vector2 worldBoundary;

    void Start()
    {
        //InitConnections();
        InitState();

        InvokeRepeating(nameof(SpawnClouds), 1f, spawnRate);
    }

    void InitConnections()
    {

    }
    void InitState()
    {
        worldBoundary = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
    }

    void Update()
    {
        
    }

    private void SpawnClouds()
    {
        Instantiate(cloudPrefab, RandomSpawnPoint(), Quaternion.identity);
    }

    Vector3 RandomSpawnPoint()
    {
        Vector3 spawnPoint = new Vector3(10, UnityEngine.Random.Range(worldBoundary.y, -(worldBoundary.y)) * 4, 0);
        return spawnPoint;
    }
}

