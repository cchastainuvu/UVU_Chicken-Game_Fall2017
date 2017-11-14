using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : MonoBehaviour {

public float moveSpeed;

void MoveForward () {
	transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
}

void Turn () {
	int randomNum = Random.Range (0,360);
	transform.Rotate (0,randomNum,0);
}

void OnTriggerStay (Collider other) {
	if (other.gameObject.tag == "Checkpoint") {
		Turn ();
	}

	else {
		MoveForward ();
	}
}


}
