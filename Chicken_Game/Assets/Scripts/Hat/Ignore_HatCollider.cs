using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ignore_HatCollider : MonoBehaviour {

void OnTriggerStay (Collider other) {
	if (other.gameObject.tag == "ChickHat") {
		 Physics.IgnoreCollision(other.GetComponent<Collider>(), GetComponent<Collider>());
	}
}


}
