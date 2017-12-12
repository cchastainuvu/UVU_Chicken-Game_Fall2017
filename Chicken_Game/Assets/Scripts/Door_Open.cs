using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Open : MonoBehaviour {

public Transform target;

void OnTriggerEnter (Collider other) {
	if (other.gameObject.name == "Player") {
	transform.LookAt (target);
}
}
}

