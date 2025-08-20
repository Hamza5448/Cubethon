using UnityEngine;

public class Endtrigger : MonoBehaviour
{
    public Gamemanager gameManager; // Reference to the GameManager script
    void OnTriggerEnter()
    {
        gameManager.CompleteLevel(); // Call the CompleteLevel method from the GameManager script when the player enters the trigger
    }
}
