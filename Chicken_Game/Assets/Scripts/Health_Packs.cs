using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_Packs : MonoBehaviour {


public GameObject playHealth;
public int healing;

void Update() {
transform.Rotate(0, 1, 0);
//Slowly rotates HealthPack horizontally.
}

public void OnTriggerStay (Collider other) {
	if (other.gameObject.name == "Player"){
		var heal = other.gameObject;
		var health = heal.GetComponent<Player_Health>();
		playHealth.gameObject.GetComponent<Player_Health>().RegainHealth(healing);
		print ("You've regained 20 health!"); 
	}
	if (playHealth != null) {}
}

}
