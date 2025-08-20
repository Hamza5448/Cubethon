using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset; // Offset from the player's position
    // Update is called once per frame
    void Update()
    {
       // Debug.Log("FollowPlayer script is running. Player position: " + player.position);
        transform.position=player.position + offset;
    }
}
