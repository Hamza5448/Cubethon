using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody Rb;
    public float ForwardForce=500f; // The force applied to the player object in the forward direction
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float SideForce = 500f; // The force applied to the player object in the side direction
    void Start()
    {
        //  Debug.Log("Hello, World! This is the PlayerMovement script starting up.");
        // rb.useGravity = false; // Disable gravity for the player objectS
       // Rb.AddForce(0,200,800);


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Rb.AddForce(0, 0, ForwardForce * Time.deltaTime);// Add a force to the player object in the forward direction

        if (Input.GetKey("d"))
        {
            Rb.AddForce(SideForce * Time.deltaTime, 0, 0 , ForceMode.VelocityChange); // Add a force to the player object in the right direction}
        }
        if (Input.GetKey("a"))
        {
            Rb.AddForce(-SideForce * Time.deltaTime, 0, 0 , ForceMode.VelocityChange); // Add a force to the player object in the left direction}
        }
        if (Rb.position.y < -3f) // Check if the player object falls below a certain height
        {
            FindObjectOfType<Gamemanager>().Gameover(); // Call the Gameover method from the Gamemanager script
        }
        if (Rb.position.y < -3f)
        {
            FindObjectOfType<Gamemanager>().Gameover();  // Trigger game over
        }
    }
}


