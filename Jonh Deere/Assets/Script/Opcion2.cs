﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Opcion2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void  OnMouseDown() {
		PlayerPrefs.DeleteAll();
		
		SceneManager.LoadScene("Inicio");

    }
}
