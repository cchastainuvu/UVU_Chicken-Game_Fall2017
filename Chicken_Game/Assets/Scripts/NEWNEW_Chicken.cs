using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NEWNEW_Chicken : MonoBehaviour {

public float moveSpeed;
public Transform target;
public Transform chickenPen;


void OnTriggerStay (Collider other) {

	if (other.gameObject.name == "Player") {
		transform.LookAt (target);
		transform.Translate (Vector3.forward * - moveSpeed * Time.deltaTime);
	}
}


}
