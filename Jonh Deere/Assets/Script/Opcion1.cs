using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opcion1 : MonoBehaviour {
public int nivel;
public bool correcto;
public Transform pos;
public Transform mark;

public Transform clicPos;
public Transform clicMark;
public AudioSource audio;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void  OnMouseDown() {
		audio.Play();
		//Debug.Log("Clic");
		mark.position = new Vector2 (pos.position.x, pos.position.y);
		clicMark.position =  new Vector2 (clicPos.position.x, clicPos.position.y);
		PlayerPrefs.SetInt("nivel", nivel );//Dice q nivel se esta cursandop
		
		if(correcto){
			PlayerPrefs.SetInt (""+nivel,1);// Dice si aprobo o no este nivel q esta jugando
			//PlayerPrefs.SetInt("aciertos", PlayerPrefs.GetInt("aciertos")+1 );// cuenta las cantidad de aciertos
		}else{
			PlayerPrefs.SetInt (""+nivel,0);// Dice si aprobo o no este nivel q esta jugando

		}
		
	}
}
