using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_Packs : MonoBehaviour {

public GameObject healthPack;
public int healing;
public GameObject playHealth;


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
	
	else {
		Debug.Log ("Player is not within range.");
	}

}


}
