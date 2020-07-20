using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class PauzaMenu : MonoBehaviour{

	public static bool GameIsPaused = false;
	public GameObject pauseMenuUI;

    public AudioMixer mixer;

	void Update(){
		if (Input.GetKeyDown(KeyCode.Escape)){

			if(GameIsPaused){
				Resume();
			}else
			{
				Pause();
			}
		}
	}
    public void Resume(){
    	pauseMenuUI.SetActive(false);
    	Time.timeScale = 1f;
    	GameIsPaused = false;
    }

    void Pause(){
    	pauseMenuUI.SetActive(true);
    	Time.timeScale = 0f;
    	GameIsPaused = true;
    }

    public void LoadMenu(){
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

    public void BackToGame(){
        SceneManager.LoadScene(1);
    }
    
    public void QuitGame(){
    	Application.Quit();
    }

    public void SetVolume(float sliderValue){
       //Debug.Log(volume);
        mixer.SetFloat("volume", Mathf.Log10 (sliderValue) * 20); 
    }

}
