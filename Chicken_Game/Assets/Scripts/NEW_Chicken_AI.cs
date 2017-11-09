using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NEW_Chicken_AI : MonoBehaviour {

// public Rigidbody enemy;

public float moveSpeed;
public Transform target;
public Transform chickenPen;
public int points = 10;

public int hopPoints = 20;

// Vector3 wayPoint;
// public int range = 10;

void OnTriggerStay (Collider other) {

	if (other.gameObject.name == "Player") {
		Debug.Log ("Player has entered the chicken's trigger.");
		transform.LookAt (target);
		transform.Translate (Vector3.forward * - moveSpeed * Time.deltaTime);

	}


	
}

void OnCollisionEnter (Collision other) {

		if (other.gameObject.name == "Player") {

			Score_Manager.AddPoints(points);

			transform.position = chickenPen.position;
			transform.rotation = chickenPen.rotation;

		}

		else if (other.gameObject.name == "Score Wall") {

			Debug.Log ("Chicken has hopped into the pen.");
			Score_Manager.AddPoints(hopPoints);

		}

}

//Beginning Wandering AI...

// void Start () {
// 	Wander ();
// }

// void Update () {

// 	transform.position += transform.TransformDirection (Vector3.forward * moveSpeed * Time.deltaTime);

// 	if ((transform.position - wayPoint). magnitude < 3) {
// 		Wander ();
// 	}

// }

// void Wander () {

// 	wayPoint = new Vector3 (Random.Range(transform.position.x - range, transform.position.x + range) , 1 , Random.Range (transform.position.z - range , transform.position.z + range));
	
// 	wayPoint.y = 1;

// 	transform.LookAt (wayPoint);

// 	// Debug.Log (wayPoint + " and " + (transform.position - wayPoint).magnitude);
// }


}
