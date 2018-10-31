using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lolipop : MonoBehaviour {



        public bool moveRight = false; //checks if the enemy moves right or left
        public float movSpeed = 2.5f; //movement of the enemy

        //Patrol Positions
        

        public GameObject parent;


        // Update is called once per frame



        //Destroys the GameObject
        public void Die()
        {
            Destroy(parent);
        }

        //flips the entire gameObject and its components



}
