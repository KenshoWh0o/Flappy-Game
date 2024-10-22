using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;

    void Start()
    {
        // Spawn of the pipe
        spawnPipe();
    }

    void Update()
    {
        // Interval between each spawn
        if (timer < spawnRate) 
        {
            timer +=Time.deltaTime;
        } else
        {
            spawnPipe();
            timer = 0;
        }

    }

    void spawnPipe()
    {
        // Randomization of the spawn
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
