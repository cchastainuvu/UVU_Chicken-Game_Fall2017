using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken_AI : MonoBehaviour {

	public Rigidbody enemy;
	public float moveSpeed;
	public Transform target;

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
	}

	}
}
