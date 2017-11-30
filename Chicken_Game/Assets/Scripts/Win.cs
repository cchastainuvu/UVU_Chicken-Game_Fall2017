using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Logic Error, not working to expectations.

public class Win : MonoBehaviour {
public int winScore;
//Total points needed to win.
private int currentScore;
//Not going to change currentScore;
public GameObject scoreManager;
//Will be stored in currentScore;
public Text winText;
//Text displayed when the player wins.

void Start () {
//Constantly check if the game has been won.
	
	//Declare scoreManager to have an object shared by Score_Manager and Win scripts.
	//"Have to have each other's phone numbers to text eachother", must communicate.

	winText.GetComponent<Text>().enabled = false;
}

void Update () {
	// currentScore = scoreManager.gameObject.GetComponentInChildren<Score_Manager>().scoreAmount;
	currentScore = scoreManager.scoreAmount;
	print("currentScore =" + currentScore);
	if (winScore == currentScore) {
		print("winScore reached" + currentScore);
		//Can enable or disable the text to appear.
		winText.GetComponent<Text>().enabled = true;
	}
}

}
