using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

// [RequireComponent (typeof(CharacterController))]
public class Wolf_AI : MonoBehaviour {

	// public Rigidbody wolf;
	public float moveSpeed;
	public Transform target;
	public int damage;
	public GameObject pcHealth;

	// public AudioSource wolfMusic;
	// public AudioClip wolf;
	// public AudioClip mainMusic;

// public AudioClip wolfMusic;
// public AudioSource audioSource;

// void Awake () {
// 	GetComponent<AudioSource> ().enabled = false;
// }


// void OnTriggerEnter (Collider other) {
// 	if (other.gameObject.name == "Player") {
// 	AudioSource music = GetComponent<AudioSource>();
// 		music.Play();
// 	// GetComponent<AudioSource>().enabled = true;
// 	// if(true) {
// 	// 	AudioSource music = GetComponent<AudioSource>();
// 	// 	music.Play();
// 	}
// }

// void OnTriggerExit (Collider other) {
// 	AudioSource music = GetComponent<AudioSource>();
//     music.Stop();
// }


void OnTriggerStay (Collider other) {
	if (other.gameObject.name == "Player") {
	
		var wanderScript = this.gameObject.GetComponent<Wander>();
		wanderScript.enabled = false;
		transform.LookAt (target);
		transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
		wanderScript.enabled = true;

	}

	if (other.gameObject.tag == "ChickHat") {
		 Physics.IgnoreCollision(other.GetComponent<Collider>(), GetComponent<Collider>());
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
		if (other.gameObject.tag == "Checkpoint") {
			Turn();
		
	}
}
}

void Turn () {
	int randomNum = Random.Range (0,360);
	transform.Rotate (0,randomNum,0);
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
