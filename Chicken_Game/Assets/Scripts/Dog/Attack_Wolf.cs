using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_Wolf : MonoBehaviour {

public int moveSpeed;
public int turnSpeed;
public int damage = 5;
public Transform target;
public Transform wolfTarget;
public Transform homeTarget;
public GameObject wolfHealth;
public AudioSource dogBark;

public string who;

void Start () {
	FollowDetermine();
}

void OnCollisionEnter (Collision other) {
	// if (other.gameObject.tag == "DogFollow") {
		// rigidbody.velocity = Vector3.zero;
		// yield WaitForSeconds(5);
	// }
	if (other.gameObject.name == "Wolf") {
		// who = "WolfDead";
		var hit = other.gameObject;
		var health = hit.GetComponent<Wolf_Health>();
		wolfHealth.gameObject.GetComponent<Wolf_Health>().TakeDamage(damage);
		AudioSource dogBark = GetComponent<AudioSource>();
		dogBark.Play();
		// CancelInvoke("FollowDetermine");
		StartCoroutine(WaitDestroy());
		// Destroy(gameObject);
	}

}

IEnumerator WaitDestroy () {
		yield return new WaitForSeconds (1);
		Destroy(gameObject);
}

void OnTriggerStay (Collider other){

	if (other.gameObject.name == "Player" && other.gameObject.name == "ThrowAwayDoor") {
		who = "WaitPlayer";
		FollowDetermine();
	}

	if (other.gameObject.name == "Player") {
		who = "Player";

		var wanderScript = this.gameObject.GetComponent<Wander>();
		wanderScript.enabled = false;
		FollowDetermine();
		
	}
	if (other.gameObject.name == "Wolf") {
		who = "Wolf";
		
		var wanderScript = this.gameObject.GetComponent<Wander>();
		wanderScript.enabled = false;
		FollowDetermine();
	}

	if (other.gameObject.name == "Player" && other.gameObject.name == "Wolf") {
		who = "Both";
		
		var wanderScript = this.gameObject.GetComponent<Wander>();
		wanderScript.enabled = false;
		FollowDetermine();
	}
	if (other.gameObject.name != "Player" && other.gameObject.name != "Wolf") {
		who = "Neither";

		var wanderScript = this.gameObject.GetComponent<Wander>();
		wanderScript.enabled = true;

	}

}


void FollowDetermine () {

	switch (who) {

		case "Player":

		transform.LookAt (target);
		transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);

		break;

		case "Wolf":
		
		transform.LookAt (wolfTarget);
		transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);

		break;

		case "Both":
		transform.LookAt (wolfTarget);
		transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
		break;

		case "Neither":

		GetComponent<Wander>();

		break;

		case "WaitPlayer":

		transform.LookAt (homeTarget);

		break;

}

}
}

