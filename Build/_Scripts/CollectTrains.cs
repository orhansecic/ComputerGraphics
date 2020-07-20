using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectTrains : MonoBehaviour{
	public AudioSource collectSound;

   void OnMouseDown(){
    	collectSound.Play();
    	ScoringSystem.theScore += 1;
    	Destroy(gameObject);

    	/*if(theScore == 1){
    		SceneManager.LoadScene(10);
    	}*/
    }
 }
