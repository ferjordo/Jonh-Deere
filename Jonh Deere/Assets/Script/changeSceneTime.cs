using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class changeSceneTime : MonoBehaviour {
int num = 0;
public int time;
public  string name ;
int nivel;
	// Use this for initialization
	void Start () {
			nivel= 	PlayerPrefs.GetInt("nivel" );//Dice q nivel se esta cursandop
			

	}
	
	// Update is called once per frame
	void Update () {
		num++;
		if(num>time){
			if(name.Equals("")){
			SceneManager.LoadScene(nivel+1);
			}else{
			SceneManager.LoadScene(name);
			}
			
		}
	}
}
