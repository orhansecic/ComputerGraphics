using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoringSystem : MonoBehaviour{
    public GameObject scoreText;
    public static int theScore;

    void Update(){
    	scoreText.GetComponent<Text>().text = "SCORE: " + theScore;
    	if(theScore == 3){
    		theScore = 0;
    		SceneManager.LoadScene(18);
    	}
    }

}
