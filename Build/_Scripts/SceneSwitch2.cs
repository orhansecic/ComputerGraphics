using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class SceneSwitch2 : MonoBehaviour{

	void OnTriggerEnter(Collider other){
		int index = Random.Range(12 , 18);
    	SceneManager.LoadScene(index);
    	Debug.Log("Scene Loaded");
	}
    
}
