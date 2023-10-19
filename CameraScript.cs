using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    // public variables allow us to set the value in the Inspector GUI
    // back in the Unity application 
    // 1)have the main camera selected
    // 2)locate the CameraScript in the inspector
    // 3)drage the player Sphere object into the public player variable
    
    public GameObject player;

    Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        //offset records how far away the camera is from the player at the start of the game
        offset =  transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //forever set the camera's position to equal where ever the player is + offset
        transform.position = player.transform.position + offset;
    }
}
