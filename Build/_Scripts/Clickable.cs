using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class Clickable : MonoBehaviour
{
	public AudioClip win;
	  AudioSource winn;

    void Start()
    {
        winn = GetComponent<AudioSource>();
        //Debug.Log("started");
    }
   void OnMouseDown(){
		winn.PlayOneShot(win);
        //SceneManager.LoadScene(8);
	}
}