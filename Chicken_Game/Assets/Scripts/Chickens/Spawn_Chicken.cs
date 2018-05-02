using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Chicken : MonoBehaviour {

public GameObject chicken;
public float spawnTime = 3f;
public Transform [] spawnPoints;

public float startDelay = 1f;
public float repeatDelay = 1f;

void Start () {
    InvokeRepeating("Spawn", startDelay, repeatDelay);
    // StartCoroutine(Spawn());

}
void Spawn () {
        int spawnPointIndex = Random.Range (0,spawnPoints.Length);
        Instantiate (chicken, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }


}




