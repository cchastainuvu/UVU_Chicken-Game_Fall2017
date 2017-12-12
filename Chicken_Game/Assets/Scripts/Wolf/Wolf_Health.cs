using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wolf_Health : MonoBehaviour {

public GameObject wolf;
public int currentHealth;
public int maxHealth = 3;
public Transform [] spawnPoint;
// public Transform underSpawn;
public int points;

void Start () {
	currentHealth = maxHealth;
}

// void OnTriggerEnter (Collider other) {
// 	if (other.gameObject.tag == "Wolf") {
// 		transform.position = spawnPoint.position;
// 		transform.rotation = spawnPoint.rotation;
// 		currentHealth = maxHealth;
// 		StartCoroutine(Respawn());
// 	}
// }


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
		// StartCoroutine(Respawn());
		//Move wolf to spawn point ofr restart
		// Destroy(wolf);
		int spawnPointIndex = Random.Range (0,spawnPoint.Length);
		// Instantiate (wolf, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
		transform.position = spawnPoint[spawnPointIndex].position;
		transform.rotation = spawnPoint[spawnPointIndex].rotation;
		// transform.rotation = spawnPoint.rotation;
		//Reset Wolf Health
		currentHealth = maxHealth;

		}
	}

// IEnumerator Respawn(){
// 	yield return new WaitForSeconds (3);
// 	transform.position = underSpawn.position;
// 	transform.rotation = underSpawn.rotation;
// 	currentHealth = maxHealth;

// }

}
