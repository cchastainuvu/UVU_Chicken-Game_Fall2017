using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Destroy : MonoBehaviour {

//Barn door will appear to open in conjuction with other half of door.

void OnTriggerEnter (Collider other) {
	if (other.gameObject.name == "Player") {
	Destroy(gameObject);
}
}

}
