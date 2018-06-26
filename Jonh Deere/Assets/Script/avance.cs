using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class avance : MonoBehaviour {
	public GameObject x1, y1 , all1;
	public  GameObject x2, y2 , all2;
	public  GameObject x3, y3 , all3;
	public  GameObject x4, y4 , all4;
	public  GameObject x5, y5 , all5;
	public  GameObject x6, y6 , all6;
	public  GameObject x7, y7 , all7;


	// Use this for initialization
	void Start () {
		PlayerPrefs.GetInt("nivel");
		Debug.Log("Nivel: "+PlayerPrefs.GetInt("nivel"));
		Debug.Log("Nivel acetado?: "+PlayerPrefs.GetInt("1"));
		Debug.Log("Aciertos: "+PlayerPrefs.GetInt("aciertos"));
		 switch (PlayerPrefs.GetInt("nivel"))
        {
		
        case 5:
		if(PlayerPrefs.GetInt("1")==1){
			Destroy(x1);
		}else{
			Destroy(y1);
		}
		if(PlayerPrefs.GetInt("2")==1){
			Destroy(x2);
		}else{
			Destroy(y2);
		}
		if(PlayerPrefs.GetInt("3")==1){
			Destroy(x3);
		}else{
			Destroy(y3);
		}
		if(PlayerPrefs.GetInt("4")==1){
			Destroy(x4);
		}else{
			Destroy(y4);
		}
		if(PlayerPrefs.GetInt("5")==1){
			Destroy(x5);
		}else{
			Destroy(y5);
		}
		Destroy(all6);

		Destroy(all7);
		
            break;
        case 4:
        if(PlayerPrefs.GetInt("1")==1){
			Destroy(x1);
		}else{
			Destroy(y1);
		}
		if(PlayerPrefs.GetInt("2")==1){
			Destroy(x2);
		}else{
			Destroy(y2);
		}
		if(PlayerPrefs.GetInt("3")==1){
			Destroy(x3);
		}else{
			Destroy(y3);
		}
		if(PlayerPrefs.GetInt("4")==1){
			Destroy(x4);
		}else{
			Destroy(y4);
		}
		
		
		Destroy(all5);
		Destroy(all6);

		Destroy(all7);
       
	   
	        break;
        case 3:
        if(PlayerPrefs.GetInt("1")==1){
			Destroy(x1);
		}else{
			Destroy(y1);
		}
		if(PlayerPrefs.GetInt("2")==1){
			Destroy(x2);
		}else{
			Destroy(y2);
		}
		if(PlayerPrefs.GetInt("3")==1){
			Destroy(x3);
		}else{
			Destroy(y3);
		}
		
		Destroy(all4);
		Destroy(all5);
		
				Destroy(all6);

		Destroy(all7);
        
		
		    break;
        case 2:
		if(PlayerPrefs.GetInt("2")==1){
			Destroy(x2);
		}else{
			Destroy(y2);
		}
		if(PlayerPrefs.GetInt("1")==1){
			Destroy(x1);
		}else{
			Destroy(y1);
		}
		Destroy(all3);
		Destroy(all4);
		Destroy(all5);
		
				Destroy(all6);

		Destroy(all7);
            break;
        case 1:
		Debug.Log("Entro en 1");
		if(PlayerPrefs.GetInt("1")==1){
			Destroy(x1);
		}else{
			Destroy(y1);
		}
	
		Destroy(all2);
		Destroy(all3);
		Destroy(all4);
		Destroy(all5);
				Destroy(all6);

		Destroy(all7);

            break;
        default:
            //print ("Incorrect intelligence level.");
            break;
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
