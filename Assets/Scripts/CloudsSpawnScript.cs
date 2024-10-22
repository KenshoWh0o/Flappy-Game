using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    public GameObject cloud;
    public float spawnRate = 10;
    private float timer = 0;
    public float heightOffset = 10;

    void Start()
    {
        // Spawn of the cloud
        spawnCloud();
    }

    void Update()
    {
        // Interval between each spawn
        if (timer < spawnRate) 
        {
            timer +=Time.deltaTime;
        } else
        {
            spawnCloud();
            timer = 0;
        }
    }

    void spawnCloud()
    {
        // Randomization of the spawn
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(cloud, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
