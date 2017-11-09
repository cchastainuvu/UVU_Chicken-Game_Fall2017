using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Manager : MonoBehaviour {

public static int score;
//Static gives variable more flexibility.


public Text text;


void Start () {
	text = GetComponent<Text>();
		score = 0;
}

void Update () {
	if (score < 0)
		score = 0;

	text.text = " " + score;
}

public static void AddPoints (int pointsToAdd) {
	score += pointsToAdd;
	//Prevents new score from replacing current total.
}

public static void AddPointsHop (int pointsToAdd2) {
	score = score + pointsToAdd2;
}
public void Reset () {
	score = 0;
}

}
