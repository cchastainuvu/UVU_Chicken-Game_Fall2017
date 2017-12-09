using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music_Trigger : MonoBehaviour {

public AudioClip battleMusic;

void OnTriggerEnter (Collider other) {
	Debug.Log ("Wolf Music is playing");
}

}
