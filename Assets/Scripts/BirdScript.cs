using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    public float deadZoneBot = -14;
    public float deadZoneTop = 14;

    void Start()
    {
        // Import of the LogicScript
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void Update()
    {
        // Control of the bird if it is alive
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }

        // Game over if the bird get out of the screen
        if (transform.position.y < deadZoneBot || transform.position.y > deadZoneTop)
        {
            logic.gameOver();
            birdIsAlive = false;
        }
    }

    // Game over if the bird collides with a pipe
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}