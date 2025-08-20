using UnityEngine;
using TMPro;  // <-- Required for TextMeshPro

public class Score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;

    // We add an if statement inside the Update() function.
    void Update()
    {
        if (player.position.y >= 3)
        {
            // Only update the score if the player's Y position is not negative.
            float displayScore = player.position.z + 170;
            scoreText.text = displayScore.ToString("F1");
        }
    }
}
