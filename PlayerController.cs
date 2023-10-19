using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Rigidbody is the physics system of Unity
    Rigidbody rb;

    //public variables allows it to be edited in the Inspector GUI
    public float speed = 40;

    // Start is called before the first frame update
    void Start()
    {
        //GetComponent is the function that retreives specific components attached to the object this script is associated with.
        rb = GetComponent<Rigidbody>();
    }

    // FixedUpdate is like a forever loop, constantly being called as long as the game is running
    // FixedUpdate is constantly called at the same rate as the physics system.
    // Place any use of the Rigidbody in FixedUpdate as it 
    void FixedUpdate()
    {
        //the AD or left/right keys on the keyboard
        //clicking the A returns a -1
        //clicking the D returns a 1
        //clicking neither keys returns 0
        //GetAxis has incrmental changes associated with it so it slowly increases/decreases from 0 to 1
        float ad = Input.GetAxis("Horizontal");
        //the WS or up/down keys on the keyboard
        //clicking the W returns a -1
        //clicking the S returns a 1
        //clicking neither keys returns 0
        float ws = Input.GetAxis("Vertical");
        //an XYZ vector similar to physics
        //ad keys will affect the X-axis
        //ws keys will affect the Z-axis
        Vector3 movement = new Vector3(ad,0,ws);
        //AddForce is a function in the rigidbody component that applies a pushing motion onto the object using the Vector3
        rb.AddForce(movement*speed*Time.deltaTime);
        //INFO DUMP:
        //Time.deltaTime is a float data that records the delay between FixedUpdate function calls in seconds
        //for example the Unity system will automatically call FixedUpdate at time 0.3 second and 0.4 second while the game is running
        //Time.deltaTime will then equate 0.1f
        // when using Time.deltaTime for movement mathematics telling the character to move (1,0,0)*Time.deltaTime means moving 1 X-step at the pace of 1 step per second
    }
}
