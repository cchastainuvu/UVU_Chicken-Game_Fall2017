using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wolf_Health : MonoBehaviour {

public GameObject wolf;
public int currentHealth;
public int maxHealth = 3;
public Transform [] spawnPoint;
public int points;

void Start () {
	currentHealth = maxHealth;
}

//TakeDamage will be called from another script.
public void TakeDamage (int amount) {
	currentHealth -= amount;

	if (currentHealth <= 0) {
		currentHealth = 0;
		print ("The Wolf is dead!");
		//Add points to score for killing wolf
		
		Score_Manager.AddPoints(points);
		
		int spawnPointIndex = Random.Range (0,spawnPoint.Length);
		transform.position = spawnPoint[spawnPointIndex].position;
		transform.rotation = spawnPoint[spawnPointIndex].rotation;
		
		currentHealth = maxHealth;

		}
	}

}
