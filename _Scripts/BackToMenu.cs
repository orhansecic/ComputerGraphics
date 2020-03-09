using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    public void MenuLoad(){
    	SceneManager.LoadScene(2);
    	Debug.Log("Menu Loaded");
    }
}
