using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

//Float will allow more precise aspects of player movement.

public GameObject chickHat;
public GameObject fakeHat;
public GameObject hatSpawn;
public GameObject bulletSpawn;

public Shoot scriptShoot;

public float moveSpeed;
public float turnSpeed;
public float jumpHeight;

// public AudioClip wolfMusic;

// public Rigidbody rigidBody;

//Anytime you have a value you would like to store and process later, use a variable.
//To be accessible to the inspector, the variables must be written with public access.
//Need to establish behavior of player before writing the script, write variables accordingly.

void Start ()   
     {
       chickHat.SetActive(false);
     } 

void Update () {

	var j = Input.GetAxis ("Jump") * Time.deltaTime * jumpHeight;
	var y = Input.GetAxis ("Horizontal") * Time.deltaTime * turnSpeed;
	var z = Input.GetAxis ("Vertical") * Time.deltaTime * moveSpeed;

/*Time.deltaTime keeps the update strictly to one specified unit per second, so faster processors
don't go crazy updating nearly 60 times per second, like my computer.*/

//Input looks for a key press or any sort of interaction from the player. Input is a class, storing info.
//GetAxis is method/function. Jump is a predefined map key, tied to space bar. GetButton alt.

//Getting access to a certain button that is already mapped for keyboard/gamepad.
//Instead of two lines of code for L/R, Horizontal covers both. Neg/Pos. buttons.

	transform.Rotate (0,y,0);
	transform.Translate (0,0,z);
	transform.Translate (0,j,0);

//Transforms: Moving, Rotating, and Scaling. Transform is the class, Rotate/Translate is the method.
//Position of var letter, axis in which direction the input will cause the item to transform.
//Not translating on x, otherwise the character may strafe or crabwalk.

//Add Rigid Body to calculate physics. Add Component > Physics > Rigid Body
//Add constraints so the capsule will not fall over. Do not freeze Y, or no turn.
}

void OnTriggerStay(Collider other) {
	
	if (other.gameObject.tag == "HatSpawn") {
		// chickHat.SetActive(true);
		// hatSpawn.SetActive(false);
		// fakeHat.SetActive(false);
		// hatSpawn.GetComponent<BoxCollider>().enabled = false;
		// Destroy(other.gameObject);
		// Destroy(fakeHat);
		Destroy(other);
		StartCoroutine(Activate());
		// StartCoroutine(WearOut());
		
}
	
}
// IEnumerator DestroySpawn() {
// 	yield return new WaitForSeconds (0);
// 	hatSpawn.GetComponent<BoxCollider>().enabled = false;
// 	fakeHat.GetComponent<BoxCollider>().enabled = false;
// 	Destroy(hatSpawn);
// 	Destroy(fakeHat);
// }

IEnumerator Activate() {
	yield return new WaitForSeconds (0);
		chickHat.SetActive(true);
		scriptShoot.enabled = false;
		fakeHat.SetActive(false);
		StartCoroutine(WearOut());
}
IEnumerator WearOut () {

	yield return new WaitForSeconds (10);
	scriptShoot.enabled = true;
	Destroy(chickHat);
}

		// void OnTriggerStay (Collider other) {

		// 	if (other.gameObject.name == "Wolf") {
		// 	GetComponent<AudioSource> ().Play ();
		// }
		// }


// void Start () {
// 	rigidBody = GetComponent<Rigidbody> ();
// }

// void OnCollisionEnter (Collider other) {

// 	if (other.gameObject.name == "Chicken") {
// 		rigidBody.velocity = new Vector3 (0,10,0);
// 	}
// 	else if (other.gameObject.name == "Wolf") {
// 		rigidBody.velocity = new Vector3 (0,10,0);
// 	}

// 	else {
// 		rigidBody.velocity = new Vector3 (0,10,0);
// 	}

// }

}
