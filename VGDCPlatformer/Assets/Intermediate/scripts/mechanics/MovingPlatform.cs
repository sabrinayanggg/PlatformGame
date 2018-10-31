using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour {


    //manages platform movement at different points
    [Header("Platform Positions")]
    public Transform movingPlatform; //platform gameObject that we will be moving

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //set the player as a child to the platform gaemObject
        //this allows movement of the player with moving platforms
        if (collision.gameObject.CompareTag("Player"))
        { 

            collision.collider.transform.SetParent(transform);
        }
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        //removes the player from being a child of this platform gameObject
        //once player is not on the platform.
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.collider.transform.SetParent(null);
        }
    }

    /*Points where the platform  will move*/
    public Transform position1; 
    public Transform position2;
    [HideInInspector] public Vector3 newPosition; //(X, Y, Z) coordinates of the platform

    [Space]

    [Header("Platform Attributes")]
    public string state; //named states on where the platform should move
    
    /*Adjusted speeds for the platform movement */
    public float platformVelocity;
    public float movementTime;

    void Start()
    {
        //initally the platform will start at some state
        ChangeTarget();
    }

    void FixedUpdate()
    {
        //update the movement of the platform
        movingPlatform.position = Vector3.Lerp(movingPlatform.position, newPosition, platformVelocity * Time.deltaTime);

    }



    void ChangeTarget()
    {
        /*check states and move platform, then we change states to update
        postion of the moving platform */

        //state names are abritrary and can program more 
        //states and positions if needed
        if (state == "Move1")
        {
            state = "Move2";
            newPosition = position2.position;
        }
        else if (state == "Move2")
        {
            state = "Move1";
            newPosition = position1.position;
        }
        else if (state == "") //default position
        {
            state = "Move2";
            newPosition = position2.position;
        }
        Invoke("ChangeTarget", movementTime);
    }
}
