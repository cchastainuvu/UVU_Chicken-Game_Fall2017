using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hat_Spawn : MonoBehaviour {

public GameObject hat;
public Transform [] hatSpawns;

void Start () {
	Spawn();
}

void Spawn () {
        int spawnPointIndex = Random.Range (0,hatSpawns.Length);
        Instantiate (hat, hatSpawns[spawnPointIndex].position, hatSpawns[spawnPointIndex].rotation);
    }
}
