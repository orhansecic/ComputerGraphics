using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class SceneSwitch : MonoBehaviour{

	void OnTriggerEnter(Collider other){
		int index = Random.Range(2 , 4);
    	SceneManager.LoadScene(index);
    	Debug.Log("Scene Loaded");
	}
    
}
