using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

// [RequireComponent (typeof(CharacterController))]
public class Wolf_AI : MonoBehaviour {

	public Rigidbody wolf;
	public float moveSpeed;
	public Transform target;
	public int damage;
	public GameObject pcHealth;

void OnTriggerStay (Collider other) {
	if (other.gameObject.name == "Player") {
		var wanderScript = this.gameObject.GetComponent<Wander>();
		wanderScript.enabled = false;
		transform.LookAt (target);
		transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
		wanderScript.enabled = true;
	}
}

public void OnCollisionEnter (Collision other) {

	if (other.gameObject.name == "Player") {
		var hit = other.gameObject;
		var health = hit.GetComponent<Player_Health>();
		print ("Wolf is attacking!");

		if (pcHealth != null) {
			pcHealth.gameObject.GetComponent<Player_Health>().TakeDamage(damage);
		}
	
	}
}
}


// void OnTriggerStay(Collider other) {

// if (other.gameObject.name == "Player") {

// 	transform.LookAt (target);
// 	transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
// }

// // else if (other.gameObject.name != "Player") {

// // 	// transform.LookAt (wanderTarget);
// // 	transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
// // }


// }


	
	//Need to refactor code / "start over".

// }
