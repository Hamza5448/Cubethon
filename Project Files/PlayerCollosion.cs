using UnityEngine;

public class PlayerCollosion : MonoBehaviour
{
    public PlayerMovement movement;
    public Gamemanager gameManager;

    void OnCollisionEnter ( Collision Info )
    {
        if (Info.collider.tag=="Obstacle")
        {
            Debug.Log("Player has collided with: " + Info.collider.name);   
            movement.enabled= false; // Disable the PlayerMovement script when colliding with an obstacle
            gameManager.Gameover();  // Use preassigned reference
        }
    }


}
