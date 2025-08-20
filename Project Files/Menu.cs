using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Load the next scene based on the current scene's build index
        Debug.Log("Button clicked "); // Log a message to the console when the button is clicked
    }
}
