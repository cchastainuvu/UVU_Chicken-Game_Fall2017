using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : MonoBehaviour {

public float moveSpeed;
public float rotSpeed;

private bool isWandering = false;
private bool isRotatingLeft = false;
private bool isRotatingRight = false;
private bool isWalking = false;

public void Update () {
	if (isWandering == false) {
		StartCoroutine (Wandering());
	}
	if (isRotatingRight == true) {
		transform.Rotate (transform.up * Time.deltaTime * rotSpeed);
	}

	if (isRotatingLeft == true) {
		transform.Rotate (transform.up * Time.deltaTime * -rotSpeed);
	}

	if (isWalking == true) {
		transform.position += transform.forward * moveSpeed * Time.deltaTime;
	}

	}

IEnumerator Wandering () {
	int rotTime = Random.Range (1,3);
	int rotWait = Random.Range (1,3);
	int rotL0rR = Random.Range (0,3);
	int walkWait = Random.Range (1,3);
	int walkTime = Random.Range (1,5);

	isWandering = true;

	yield return new WaitForSeconds (walkWait);
	isWalking = true;
	yield return new WaitForSeconds (rotTime);
	isWalking = false;
	yield return new WaitForSeconds (rotWait);
	if (rotL0rR == 1) {
		isRotatingRight = true;
		yield return new WaitForSeconds (rotTime);
		isRotatingLeft = false;
	}

	if (rotL0rR == 2) {
		isRotatingLeft = true;
		yield return new WaitForSeconds (rotTime);
		isRotatingLeft = false;
	}

	isWandering = false;

}





}








// void MoveForward () {
// 	transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
// }

// void Turn () {
// 	int randomNum = Random.Range (0,360);
// 	transform.Rotate (0,randomNum,0);
// }

// void OnTriggerStay (Collider other) {
// 	if (other.gameObject.tag == "Checkpoint") {
// 		Turn ();
// 	}

// 	else {
// 		MoveForward ();
// 	}
// }


// }
