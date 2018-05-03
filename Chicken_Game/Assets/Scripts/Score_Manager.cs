using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score_Manager : MonoBehaviour {

public static int score;
	
//Static gives variable more flexibility.
//Usually other properties will need to be static to use with static variable.

public int scoreAmount = score;
public Text text;

public Text winText;
public int winScore;

void Awake () {
	Time.timeScale = 1;
}


void Start () {
	text = GetComponent<Text>();
		score = 0;

	winText.GetComponent<Text>().enabled = false;
}

void Update () {

	if (score < 0)
		score = 0;

	text.text = " " + score;


	if (score >= winScore ) {
		print("winScore reached" + score);
		//Can enable or disable the text to appear.
		winText.GetComponent<Text>().enabled = true;
		Time.timeScale = 0;
	}
	

	if (Input.GetKeyDown(KeyCode.Escape) && score != winScore){

		SceneManager.LoadScene(0);
	}

	if (score>=winScore && Input.GetKeyDown(KeyCode.Escape)){
		AudioSource applause = GetComponent<AudioSource>();
		applause.Play();
		LevelLoad();
	}
}


void LevelLoad() {
	SceneManager.LoadScene(0);
}



public static void AddPoints (int pointsToAdd) {
	score += pointsToAdd;
	//Prevents new score from replacing current total.
}


public static void TakePoints (int pointsToTake) {
	score -= pointsToTake;
}

public void Reset () {
	score = 0;
}

}
