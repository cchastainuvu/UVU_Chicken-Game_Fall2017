using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wandering_AI : MonoBehaviour {

public float moveSpeed;
public float rotSpeed;

Vector3 turnAround = new Vector3 (0,1,0);

void Update () {
	Wander();
}

void Wander () {
	transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
}

void OnTriggerStay (Collider other) {
	
	if (other.gameObject.tag == "wall") {
		Debug.Log ("Wall has been triggered.");
		transform.Rotate (turnAround * rotSpeed * Time.deltaTime);
	}

}


}
