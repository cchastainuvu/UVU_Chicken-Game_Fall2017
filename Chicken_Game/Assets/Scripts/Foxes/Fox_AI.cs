using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox_AI : MonoBehaviour {

public Transform foxSpawn;
public Transform target;
// public Transform target2;
// public Transform target3;
// public Transform target4;
// public Transform target5;
public float moveSpeed;
// public int points = 5;
public AudioSource foxCry;

void Start () {
	target = GameObject.FindWithTag("Chicken").transform;
	// target2= GameObject.FindWithTag("Chicken").transform;
	// target3= GameObject.FindWithTag("Chicken").transform;

}

void OnTriggerStay (Collider other) {
	if (other.gameObject.tag == "Chicken") {
		var wanderScript = this.gameObject.GetComponent<Wander>();
		wanderScript.enabled = false;
		transform.LookAt (target);
		transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
		wanderScript.enabled = true;

		// Score_Manager.TakePoints(points);
	}
}

public void OnCollisionEnter (Collision other) {

	if (other.gameObject.tag == "Bullet") {

		transform.position = foxSpawn.position;
		transform.rotation = foxSpawn.rotation;
	}
	// if (other.gameObject.tag == "Chicken") {
	// 	// var hit = other.gameObject;
	// 	// var health = hit.GetComponent<Player_Health>();
	// 	// print ("Wolf is attacking!");
		
	// 	// if (pcHealth != null) {
	// 	// 	pcHealth.gameObject.GetComponent<Player_Health>().TakeDamage(damage);

	// 	Destroy(other.gameObject);
		// }
		if (other.gameObject.tag == "Checkpoint") {
			Turn();
	}
	else if (other.gameObject.tag == "Player") {
		AudioSource foxCry = GetComponent<AudioSource>();
		foxCry.Play();
	}
}


void Turn () {
	int randomNum = Random.Range (0,360);
	transform.Rotate (0,randomNum,0);
}

}
