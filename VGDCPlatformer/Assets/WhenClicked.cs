﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WhenClicked : MonoBehaviour {

    public string scene;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    public void GoToScene(){
        Debug.Log('e');
        SceneManager.LoadScene(scene);
    }
}
