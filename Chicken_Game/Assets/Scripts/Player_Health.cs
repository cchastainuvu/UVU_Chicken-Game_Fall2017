using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Health : MonoBehaviour {

public const int maxHealth = 10;
public int currentHealth = maxHealth;
//Set to maxHealth, because if maxHealth is changed, currentHealth will change. Starting point.

public Text hp;
public Text maxHp;


void Update () {

	hp.text = currentHealth.ToString();
	maxHp.text = maxHealth.ToString();

//Must convert integer to a string through parsing.

}

public void TakeDamage (int amount) {

//Argument declaration not necessary. Alternatively, a type or no argument can be stored as well.

currentHealth -= amount;

if (currentHealth <= 0) {
	currentHealth = 0;
	print ("You're Dead! Game Over!");
}

}

}
