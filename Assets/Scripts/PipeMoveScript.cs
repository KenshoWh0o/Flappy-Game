using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{

    public float moveSpeed = 5;
    public float deadZone = -40;

    void Update()
    {
        // Move of the pipes
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        // Delete of the pipes when out of the screen
        if (transform.position.x < deadZone)
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
    }
}
