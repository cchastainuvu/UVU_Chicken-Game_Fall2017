using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enable_Hat : MonoBehaviour {

	public GameObject chickHat;
	public string what;


	void Start () {
	gameObject.GetComponent<BoxCollider>().enabled = false;
	gameObject.GetComponent<MeshRenderer>().enabled = false;
	}


	public void OnTriggerStay (Collider other) {

	if (other.gameObject.tag == "HatSpawn") {
		// StartCoroutine(ShowHat());
		chickHat.SetActive(true);
		StartCoroutine(ShowHat());
	}

	if (other.gameObject.tag != "HatSpawn") {
		chickHat.SetActive(false);
	}
	// other.gameObject.GetComponent<BoxCollider>().enabled = true;
	// other.gameObject.GetComponent<MeshRenderer>().enabled = true;

}


// void EnableHat () {

// 	switch (what) {

// 		case "Spawn":

// 		StartCoroutine(ShowHat());
// 		// gameObject.GetComponent<BoxCollider>().enabled = true;
// 		// gameObject.GetComponent<MeshRenderer>().enabled = true;

// 		break;

// 		case "Not Spawn":

// 		gameObject.GetComponent<BoxCollider>().enabled = false;
// 		gameObject.GetComponent<MeshRenderer>().enabled = false;

// 		break;


// 	}
// }

// void HideHat () {
// 	gameObject.GetComponent<BoxCollider>().enabled = false;
// 	gameObject.GetComponent<MeshRenderer>().enabled = false;
// }

IEnumerator ShowHat() {
	yield return new WaitForSeconds (2);
		// gameObject.GetComponent<BoxCollider>().enabled = true;
		// gameObject.GetComponent<MeshRenderer>().enabled = true;
		// StartCoroutine(DestroyHat());
		chickHat.SetActive(true);

}

IEnumerator DestroyHat () {
	yield return new WaitForSeconds (5);
	Destroy(gameObject);
}

}
