using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Opcion2 : MonoBehaviour {
public AudioSource audio;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void  OnMouseDown() {
		audio.Play();
		PlayerPrefs.DeleteAll();
		
		SceneManager.LoadScene("Inicio");

    }
}
