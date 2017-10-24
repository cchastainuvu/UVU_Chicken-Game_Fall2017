using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wolf_AI : MonoBehaviour {

	public Rigidbody wolf;
	public float moveSpeed;
	public Transform target;


void Random () {}

void OnTriggerStay(Collider other) {

if (other.gameObject.name == "Player") {
	transform.LookAt (target);
	transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
}

}

}


