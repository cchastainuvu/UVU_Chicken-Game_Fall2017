using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NEW_Chicken_AI : MonoBehaviour {

// public Rigidbody enemy;

// Regular variables:
public float moveSpeed;
public Transform target;
public Transform chickenPen;
// public Transform chickenSpawn;
public int points = 10;
public int time = 4;

// void Update () {
// 	StartCoroutine(SpawnChicken());
// }

void OnTriggerStay (Collider other) {
	if (other.gameObject.name == "Player") {
		Debug.Log ("Player has entered the chicken's trigger.");
		var wanderScript = this.gameObject.GetComponent<Wander>();
		wanderScript.enabled = false;
		// transform.LookAt(target);
		transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
		transform.rotation = Quaternion.Inverse (target.rotation);
		wanderScript.enabled = true;
	}
}

void OnCollisionEnter (Collision other) {
	if (other.gameObject.name == "Player"){
		Score_Manager.AddPoints(points);

		transform.position = chickenPen.position;
		transform.rotation = chickenPen.rotation;
	}
		if (other.gameObject.tag == "Checkpoint") {
			Turn();
	}
	if (other.gameObject.tag == "Fox") {
		// transform.position = chickenSpawn.position;
		// transform.rotation = chickenSpawn.rotation;
		// SpawnChicken();
		Destroy(gameObject);
	}

	if (other.gameObject.tag == "Bullet") {
		Score_Manager.TakePoints(points);
	}
}

void Turn () {
	// int randomNum = Random.Range (0,360);
	transform.Rotate (0,172,0);
	transform.Translate (Vector3.forward);

}

// IEnumerator SpawnChicken () {
// 	yield return new WaitForSeconds(time);
// 	transform.position = chickenSpawn.position;
// 	transform.rotation = chickenSpawn.rotation;
// }






}






// void OnTriggerExit(Collider other) {
// 	if (other.gameObject.tag == "Checkpoint") {
// 		Turn();
// 	}
// 	// else if {
// 	// if (other.gameObject.name )
// 	// }
// }
// void Turn () {
// 	int randomNum = Random.Range (0,360);
// 	transform.Rotate (0,randomNum,0);
// }

// void MoveForward () {
// 	transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
// }


// void OnTriggerStay (Collider other) {

// 	if (other.gameObject.name == "Player") {
// 		Debug.Log ("Player has entered the chicken's trigger.");
// 		// transform.LookAt (target);
// 		transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
// 		transform.rotation = Quaternion.Inverse (target.rotation);
// 	}

// }

// void OnCollisionEnter (Collision other) {

// 		if (other.gameObject.name == "Player") {

// 			Score_Manager.AddPoints(points);

// 			transform.position = chickenPen.position;
// 			transform.rotation = chickenPen.rotation;

// 		}
// }

