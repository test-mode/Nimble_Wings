using System;
using UnityEngine;


public class CloudSpawnerScript : MonoBehaviour
{
    // Settings

    // Connections

    // State Variables
    public GameObject cloudPrefab;
    Vector2 worldBoundary;

    void Start()
    {
        //InitConnections();
        InitState();

        InvokeRepeating(nameof(SpawnClouds), 1f, 1f);
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

