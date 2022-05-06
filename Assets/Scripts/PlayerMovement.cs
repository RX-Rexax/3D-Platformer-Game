using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewayForce = 500f;

    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("Hello Player!");     // Print at Unity Console
    }

    // Update is called once per frame (use FixedUpdate if making physics)
    void FixedUpdate()
    {
        // Add a Force on the z-axis
        // Time.deltaTime to optimize FPS to all kinds of PC / Devices
        // Else different devices may have different speed
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            // ForceMode.VelocityChange to increase smoothness while moving the player
        }
        
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)    // when the player falls (player position y lower than -1)
        {
            FindObjectOfType<GameManager>().EndGame();  // Access the GameManager object
        }
    }
}
