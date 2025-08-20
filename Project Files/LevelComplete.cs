using UnityEngine;
using UnityEngine.SceneManagement; // Import SceneManagement to handle scene loading
public class LevelComplete : MonoBehaviour
{
    public void LoadNextLevel() // Method to load the next level
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Load the next scene based on the current scene's build index    
    }
}
 