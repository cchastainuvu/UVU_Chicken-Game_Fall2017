using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(CharacterController))]
public class Wolf_AI : MonoBehaviour {

	public Rigidbody wolf;
	public float moveSpeed;
	public Transform target;

//Variables for wandering_AI

	// public float directionChangeInterval = 1;
	// public float maxHeadingCharge = 30;

	// CharacterController controller;
	// float heading;
	// Vector3 targetRotation;

void OnTriggerStay(Collider other) {

if (other.gameObject.name == "Player") {
	transform.LookAt (target);
	transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
}
}

// void Awake () {
// 	controller = GetComponent<CharacterController>();

// 	heading = Random.Range (0,360);
// 	transform.eulerAngles = new Vector3 (0,heading,0);

// 	StartCoroutine(NewHeading());
// }

// void Update () {
// 	transform.eulerAngles = Vector3.Slerp (transform.eulerAngles , targetRotation , Time.deltaTime * directionChangeInterval);
// 	var forward = transform.TransformDirection (Vector3.forward);
// 	controller.SimpleMove (forward * moveSpeed);
// }

// IEnumerator NewHeading () {
// 	while (true) {
// 		NewHeadingRoutine ();
// 		yield return new WaitForSeconds (directionChangeInterval);
// 	}
// }
	
// void NewHeadingRoutine () {
// 	var floor = transform.eulerAngles.y - maxHeadingCharge;
// 	var ceiling = transform.eulerAngles.y + maxHeadingCharge;

// 	heading = Random.Range (floor , ceiling);
// 	targetRotation = new Vector3 (0 , heading , 0);
// }

}