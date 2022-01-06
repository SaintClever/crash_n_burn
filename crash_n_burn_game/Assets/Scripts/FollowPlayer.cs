using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player; // We assign this in the unity engine. In the Main Camera's properties. This is the Vehicle
    private Vector3 offset = new Vector3(0, 5, -8);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate() // Because our camera is jitter use LateUpdate so it can follow the our vechile smoothly
    {
        // Set the camera xyz position to the vehicle aka the player
        // offset the camera behind the player by adding to the player's position
        transform.position = player.transform.position + offset;
    }
}
