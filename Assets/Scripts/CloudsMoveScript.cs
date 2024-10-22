using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudsMoveScript : MonoBehaviour
{
     public float moveSpeed = 2;
    public float deadZone = -30;

    void Update()
    {
        // Move of the clouds
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        // Delete of the clouds when out of the screen
        if (transform.position.x < deadZone)
        {
            Debug.Log("Clouds Deleted");
            Destroy(gameObject);
        }
    }
}
