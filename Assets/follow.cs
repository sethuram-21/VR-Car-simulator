using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    [SerializeField] private Vector3 offset = new Vector3(0, 5, -10); // Offset position from the player
    private Transform playerTransform;

    void Start()
    {
        // Find the player by tag
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            playerTransform = player.transform;
        }
        else
        {
            Debug.LogError("Player object with tag 'Player' not found!");
        }
    }

    void LateUpdate()
    {
        // Update camera position to follow player with an offset if player is assigned
        if (playerTransform != null)
        {
            // Set the camera position based on the player's position and offset
            transform.position = playerTransform.position + playerTransform.rotation * offset;
            
            // Make the camera look at the player, ensuring it follows the car's rotation
            transform.LookAt(playerTransform.position);
        }
    }
}
