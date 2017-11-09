using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : MonoBehaviour {

public float moveSpeed;


void MoveForward () {
	transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);

//MoveForward must be called before it can run within Unity and move forward.
}

void Turn () {
	int randomNum = Random.Range(0,360);
	transform.Rotate (0,randomNum,0);
//Zeroes put in, because are going to turn but set in degrees. Hit trigger, rotate randomly to avoid repeats
//Randomize the number between 0 and 360, integer. Y set to randomNum to allow obect to turn. Zero to 360 dg.
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
