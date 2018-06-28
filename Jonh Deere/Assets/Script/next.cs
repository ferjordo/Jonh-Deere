using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class next : MonoBehaviour {
	int nivel, aciertos;
public AudioSource audio;

	// Use this for initialization
	void Start () {
						}
	
	// Update is called once per frame
	void Update () {
		
	}
	void  OnMouseDown() {

		audio.Play();
		nivel= 	PlayerPrefs.GetInt("nivel" );//Dice q nivel se esta cursandop
					aciertos= 	PlayerPrefs.GetInt("aciertos" );//Dice q nivel se esta cursandop


		//Debug.Log("Se ha dado Clic");
		if(nivel == 7){
if(aciertos>6){
	SceneManager.LoadScene(10);	
}else {
		SceneManager.LoadScene(11);	
}
	
		}else{
		SceneManager.LoadScene(nivel+1);
		}
		

    }
}
