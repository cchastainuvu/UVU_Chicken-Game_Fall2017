using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hat_Spawn : MonoBehaviour {

public GameObject hat;
public Transform [] hatSpawns;

// public string what;

void Start () {
	Spawn();
}

// void FixedUpdate() {
// 	transform.Rotate(0, 100f * Time.deltaTime, 0);
// }

void Spawn () {
        int spawnPointIndex = Random.Range (0,hatSpawns.Length);
        // yield return new WaitForSeconds (spawnTime);
        Instantiate (hat, hatSpawns[spawnPointIndex].position, hatSpawns[spawnPointIndex].rotation);
    }
}
