using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHat_Spin : MonoBehaviour {

	void FixedUpdate() {
	transform.Rotate(0, 100f * Time.deltaTime, 0);
	}

}
