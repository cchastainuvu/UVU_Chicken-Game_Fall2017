using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_Packs : MonoBehaviour {

public GameObject healthPack;
public int healing;
public GameObject playHealth;
// public GameObject healthSpawnPoint;
// public Transform [] healthSpawns;
// public float spawnTime = 3f;


// void Start () {
// 	healthSpawn [1] = healthSpawn [1];
// 	healthSpawn [2] = healthSpawn [2];
// 	healthSpawn [3] = healthSpawn [3];
// }

// void Start () {
// 	Spawn();
// }

void FixedUpdate() {
	transform.Rotate(0, 100f * Time.deltaTime, 0);
	//Slowly rotates HealthPack horizontally.
}

public void OnTriggerStay (Collider other) {
	if (other.gameObject.name == "Player"){
		var heal = other.gameObject;
		var health = heal.GetComponent<Player_Health>();
		playHealth.gameObject.GetComponent<Player_Health>().RegainHealth(healing);
		print ("You've regained 20 health!"); 
	}
	// if (playHealth != null) {}
	
	// if (other.gameObject.name == "Player" && other.gameObject.name == "Spawn 1") {
	// 	transform.position = healthSpawn2.position;
	// 	transform.rotation = healthSpawn2.rotation;
	// }
	// if (other.gameObject.name == "Player" && other.gameObject.name == "Spawn 2") {
	// 	transform.position = healthSpawn3.position;
	// 	transform.rotation = healthSpawn3.rotation;
	// }
	// if (other.gameObject.name == "Player" && other.gameObject.name == "Spawn 3") {
	// 	transform.position = healthSpawn.position;
	// 	transform.rotation = healthSpawn.rotation;
	// }
	else {
		Debug.Log ("Player is not within range.");
	}

}

// public void OnTriggerEnter (Collider other) {
	
// }

// public void Spawn () {
//         int spawnPointIndex = Random.Range (0,healthSpawns.Length);

// 		Instantiate (healthPack, healthSpawns[spawnPointIndex].position, healthSpawns[spawnPointIndex].rotation);
//     }
}
