using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour{
	
	public void PlayAgain(){
    	int index = Random.Range(2 , 5);
    	SceneManager.LoadScene(index);
    	//Debug.Log("Scene is loaded again");
    }

    public void Back(){
    	SceneManager.LoadScene(9);
    	//Debug.Log("Game Loaded");
    }

    public void PlayAgainLevel2(){
    	int index = Random.Range(5 , 8);
    	SceneManager.LoadScene(index);
    }
    
}
