﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PindahScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PindaHalaman(string namascene)
	{
		SceneManager.LoadScene(namascene);
	}

    public void Quits() {
        Application.Quit();
    }
  
    
}
