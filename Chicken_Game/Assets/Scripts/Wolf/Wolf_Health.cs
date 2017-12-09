using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wolf_Health : MonoBehaviour {

public int currentHealth;
public int maxHealth = 3;
public Transform spawnPoint;
public int points;

void Start () {
	currentHealth = maxHealth;
}


//TakeDamage will be called from another script.
public void TakeDamage (int amount) {
	currentHealth -= amount;

	// if (currentHealth < 3 && currentHealth > 0) {
	// 	Score_Manager.AddPoints(points);
	// }

	if (currentHealth <= 0) {
		currentHealth = 0;
		print ("The Wolf is dead!");
		//Add points to score for killing wolf
		Score_Manager.AddPoints(points);
		//Move wolf to spawn point ofr restart
		transform.position = spawnPoint.position;
		transform.rotation = spawnPoint.rotation;
		//Reset Wolf Health
		currentHealth = maxHealth;

		}
	}



}
