using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Health : MonoBehaviour {

public const int maxHealth = 100;
public int currentHealth = maxHealth;
//Set to maxHealth, because if maxHealth is changed, currentHealth will change. Starting point.

public Text hp;
public Text maxHp;

public Text loseText;

void Awake () {
	Time.timeScale = 1;
	loseText.GetComponent<Text>().enabled = false;
}

void Update () {

	hp.text = currentHealth.ToString();
	maxHp.text = maxHealth.ToString ();

	if (currentHealth == 0) {
	loseText.GetComponent<Text>().enabled = true;
	Time.timeScale = 0;

//Must convert integer to a string through parsing.

}
}

public void TakeDamage (int amount) {

//Argument declaration not necessary. Alternatively, a type or no argument can be stored as well.

currentHealth -= amount;

if (currentHealth <= 0) {
	currentHealth = 0;
	print ("You're Dead! Game Over!");
}


}
public void RegainHealth (int amount) {

	currentHealth += amount;

	if (currentHealth > 0 && currentHealth < 100){
		currentHealth = currentHealth + 20;
		print ("You have been healed!");
	}
	if (currentHealth > 100) {
		currentHealth = 100;
	}



}

}
