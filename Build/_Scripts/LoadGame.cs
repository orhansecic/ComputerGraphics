﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToGame : MonoBehaviour
{
    public void Load(){
    	SceneManager.LoadScene(1);
    	Debug.Log("Menu Loaded");
    }
}
