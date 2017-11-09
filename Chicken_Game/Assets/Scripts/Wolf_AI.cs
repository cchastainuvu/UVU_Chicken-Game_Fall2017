using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

// [RequireComponent (typeof(CharacterController))]
public class Wolf_AI : MonoBehaviour {


// 	public Rigidbody wolf;
	public float moveSpeed;
	public Transform target;
	public Transform wanderTarget;
	public int damage;

// 	public int points = -10;

// //Variables for wandering_AI

// public float speed = 5;
// 	public float directionChangeInterval = 1;
// 	public float maxHeadingChange = 30;

// 	CharacterController controller;
// 	float heading;
// 	Vector3 targetRotation;

// void Start () {

// }

void OnTriggerStay(Collider other) {

if (other.gameObject.name == "Player") {

	transform.LookAt (target);
	transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
}

else if (other.gameObject.name != "Player") {

	transform.LookAt (wanderTarget);
	transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
}


}

public void OnCollisionEnter (Collision other) {

	var hit = other.gameObject;
	var health = hit.GetComponent<Player_Health>();

	if (other.gameObject.name == "Player" && health != null) {

		health.TakeDamage(damage);
	
	}
	
	print ("Wolf is attacking!");

	//Need to refactor code / "start over".


// void Awake () {
// 	controller = GetComponent <CharacterController>();
// 	heading = Random.Range (0,360);
// 	transform.eulerAngles = new Vector3 (0 , heading , 0);

// 	StartCoroutine (NewHeading());
// }

// void Update ()
// 	{
// 		transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, targetRotation, Time.deltaTime * directionChangeInterval);
// 		var forward = transform.TransformDirection(Vector3.forward);
// 		controller.SimpleMove(forward * speed);
// 	}
 
// 	IEnumerator NewHeading ()
// 	{
// 		while (true) {
// 			NewHeadingRoutine();
// 			yield return new WaitForSeconds(directionChangeInterval);
// 		}
// 	}

// 	void NewHeadingRoutine ()
// 	{
// 		var floor = Mathf.Clamp(heading - maxHeadingChange, 0, 360);
// 		var ceil  = Mathf.Clamp(heading + maxHeadingChange, 0, 360);
// 		heading = Random.Range(floor, ceil);
// 		targetRotation = new Vector3(0, heading, 0);
// 	}

}

}