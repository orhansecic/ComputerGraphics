using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{
    public void Back(){
    	SceneManager.LoadScene(1);
    	//Debug.Log("Menu Loaded");
    }
    public void Play(){
    	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    	Time.timeScale = 1f;
    }
}
