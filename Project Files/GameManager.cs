using UnityEngine;
using UnityEngine.SceneManagement; // Import SceneManagement to handle scene loading
public class Gamemanager : MonoBehaviour
{
    bool gamehasended = false;// Variable to track if the game has ended
    public float restartDelay = 0.000000001f; // Delay before restarting the game
    public GameObject CompleteLevelUI;// UI element to show when the level is completed
    public void CompleteLevel() // Method to be called when the level is completed
    {
        CompleteLevelUI.SetActive(true); // Activate the UI element to show level completion
    }

    public void Gameover()
    {
        if (gamehasended == false)
        {
            gamehasended = true; // Set the game has ended to true
            Debug.Log("Game Over");
            Invoke("Restart",restartDelay); // Call the Restart method to restart the game
        }
       
    }
    void Restart() 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reload the current scene to restart the game

    } 
}
