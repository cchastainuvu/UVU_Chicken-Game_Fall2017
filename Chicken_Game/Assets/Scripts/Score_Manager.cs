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

// public int pcHealth;
// public GameObject healthMonitor;
public Text text;

public Text winText;
// public Text loseText;
public int winScore;
// public int loseScore;

// public AudioClip applause;
// public AudioSource applause;

void Awake () {
	Time.timeScale = 1;
}


void Start () {
	text = GetComponent<Text>();
		score = 0;

	winText.GetComponent<Text>().enabled = false;

	// StartCoroutine(LoadAfterDelay("MainScreen"));
}

void Update () {
	
	// pcHealth = healthMonitor.gameObject.GetComponent<Player_Health>().currentHealth;
	// pcHealth = healthMonitor.currentHealth;

	if (score < 0)
		score = 0;

	text.text = " " + score;


	if (score >= winScore ) {
		print("winScore reached" + score);
		//Can enable or disable the text to appear.
		winText.GetComponent<Text>().enabled = true;
		Time.timeScale = 0;
	}

	// if (pcHealth <= 0)
	// 	loseText.GetComponent<Text>().enabled = true;
	// 	Time.timeScale=0;
	

	if (Input.GetKeyDown(KeyCode.Escape)){
		// AudioSource applause = GetComponent<AudioSource>();
		// applause.Play();
		// yield return new WaitForSeconds(2);
		SceneManager.LoadScene(0);
		// StartCoroutine(LoadAfterDelay());
		// StartCoroutine(LoadSound("MainScreen"));
	}

	if (Input.GetKeyDown(KeyCode.Escape) && score>=winScore){
		AudioSource applause = GetComponent<AudioSource>();
		applause.Play();
	}
}

// public void ModeSelect () {
	
// }

// IEnumerator LoadAfterDelay (string levelName) {


// 	if (Input.GetKeyDown(KeyCode.Escape)) {
// 	yield return new WaitForSeconds(2);
// 		SceneManager.LoadScene(0);
// 	AudioSource applause = GetComponent<AudioSource>();
// 		applause.Play();
	
// }
// }

// IEnumerator LoadSound(string mainMenu){

// 	if (Input.GetKeyDown(KeyCode.Escape)){
//              yield return new WaitForSeconds(0f); // wait time
//          	GetComponent<AudioSource>().PlayOneShot(applause);
 
//          	yield return new WaitForSeconds(1f);
 
//          	SceneManager.LoadScene(0);
// }
// }

public static void AddPoints (int pointsToAdd) {
	score += pointsToAdd;
	//Prevents new score from replacing current total.
}

// public static void AddPointsHop (int pointsToAdd2) {
// 	score = score + pointsToAdd2;
// }


public static void TakePoints (int pointsToTake) {
	score -= pointsToTake;
}

public void Reset () {
	score = 0;
}

}
