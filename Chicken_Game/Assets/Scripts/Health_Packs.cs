using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_Packs : MonoBehaviour {

public int healing;
public GameObject playHealth;
// public GameObject healthSpawnPoint;
public Transform healthSpawn;
public Transform healthSpawn2;
public Transform healthSpawn3;


// void Start () {
// 	healthSpawn [1] = healthSpawn [1];
// 	healthSpawn [2] = healthSpawn [2];
// 	healthSpawn [3] = healthSpawn [3];
// }

void Update() {
	transform.Rotate(0, 0.5f, 0);
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
	
	if (other.gameObject.name == "Player" && other.gameObject.name == "Spawn 1") {
		transform.position = healthSpawn2.position;
		transform.rotation = healthSpawn2.rotation;
	}
	if (other.gameObject.name == "Player" && other.gameObject.name == "Spawn 2") {
		transform.position = healthSpawn3.position;
		transform.rotation = healthSpawn3.rotation;
	}
	if (other.gameObject.name == "Player" && other.gameObject.name == "Spawn 3") {
		transform.position = healthSpawn.position;
		transform.rotation = healthSpawn.rotation;
	}
}

public void OnTriggerEnter (Collider other) {
	
}

}
