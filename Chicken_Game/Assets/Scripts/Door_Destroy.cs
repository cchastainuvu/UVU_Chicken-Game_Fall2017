using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Destroy : MonoBehaviour {



void OnTriggerEnter (Collider other) {
	if (other.gameObject.name == "Player") {
	Destroy(gameObject);
}
}

}
