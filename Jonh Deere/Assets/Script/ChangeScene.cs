using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour {

public string Name;
	
	
	void Start () {
	}
	
	void FixedUpdate () {

	}
/*
 PlayerPrefs.SetInt("Player Score", 10);
 */


	void Update(){
//Debug.Log("Se ha dado count");
  
	}
	
	void  OnMouseDown() {
		//Debug.Log("Se ha dado Clic");
		SceneManager.LoadScene(Name);

    }
}
