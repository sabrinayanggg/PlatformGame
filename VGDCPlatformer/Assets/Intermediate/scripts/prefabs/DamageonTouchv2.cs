using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageonTouchv2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
    }

        public void OnTriggerEnter2D(Collider2D collision)
        {
            //if this object touches an enemy's hurtbox
            if (collision.gameObject.tag == "hurtbox2")
            {
                //to kill enemy, we call enemy script Die() function to kill object
                TheBoss script = collision.gameObject.GetComponentInParent<TheBoss>();
                script.Oof();
            Debug.Log("ouch");
            }
        }
    
}

