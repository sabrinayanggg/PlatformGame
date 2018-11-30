using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheBoss : MonoBehaviour {

    public int starthealth = 10;
    public int health;
    public GameObject parent;
	// Use this for initialization
	void Start () {
        health = starthealth;
	}
   void Update () {
		if (health <= 0)
            {
            Destroy(parent);
            Debug.Log("ded");
            }
	}

    public void Oof()
    {
        health--;
    }
}
