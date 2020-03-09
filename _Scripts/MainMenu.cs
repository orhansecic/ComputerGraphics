using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //for using scenes in unity

public class MainMenu : MonoBehaviour{

	//function called whenever we press play button
	//because we are calling it from the button we need to set it to public
	public void PlayGame(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void QuitGame(){
		//Debug.Log("Quit!");
		Application.Quit();
	}
     
}
