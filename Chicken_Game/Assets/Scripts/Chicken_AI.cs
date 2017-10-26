using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(CharacterController))]
public class Chicken_AI : MonoBehaviour {

	public Rigidbody enemy;
	public float moveSpeed;
	public Transform target;
	public Transform chickenPen;

public float speed = 5;
public float directionChangeInterval = 1;
public float maxHeadingChange = 30;

CharacterController controller;
float heading;
Vector3 targetRotation;

/*Apply Box Collider to Chicken and check "Is Trigger". Collider will
bounce off contact, walls, floor, etc. Triggers allow passing through.*/

//Trigger will log everything that enters and exits the trigger.

	void OnTriggerStay (Collider other) {

	//OnTriggerEnter only works once. OnTriggerStay continues to check.

	/*Other is a temporary variable only placed in argue, pass info
	through. Whatever enters into trigger is stored in other.*/

	//Discriminate what the chicken's trigger will respond to.

		if (other.gameObject.name == "Player") {
			Debug.Log ("Player has entered the chicken's trigger.");
			transform.LookAt (target);
			transform.Translate (Vector3.forward * - moveSpeed * Time.deltaTime);

		// - before moveSpeed causes the chicken to run away from the player.
		//Alternatively Vector3.back will cause a negative movement away.
		//Maybe use OnTriggerEnter to trigger wandering AI?
	}

	}

	void OnCollisionEnter (Collision other) {
		//"Collider" is used with "Trigger". "Collision" is used with "Collision".

		if (other.gameObject.name == "Player") {
			transform.position = chickenPen.position;
			transform.rotation = chickenPen.rotation;

			//If changed to other.transform, Player would be transported to Chicken Pen.
		}
	}

}
