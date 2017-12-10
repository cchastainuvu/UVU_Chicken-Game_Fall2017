using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Chicken : MonoBehaviour {

public GameObject chicken;
public float spawnTime = 3f;
public Transform [] spawnPoints;

public float startDelay = 1f;
public float repeatDelay = 80f;

void Start () {
    InvokeRepeating("Spawn", startDelay, repeatDelay);
    // StartCoroutine(Spawn());

}
void Spawn () {
        int spawnPointIndex = Random.Range (0,spawnPoints.Length);
        // yield return new WaitForSeconds (spawnTime);
        Instantiate (chicken, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }


}


// public Rigidbody chicken;
// public float spawnRate = 5f;
//instantiates chicken every 5 seconds
// public int dummyVar = 1;
// public float speed = 0f;
// public float lifetime = 3.0f;


// public GameObject chickenPrefab;
// public Transform chickenSpawn;

// public float spawnRate = 8.0f;


//     void Start() {
//         StartCoroutine(SpawnChicken());
//     }

//     IEnumerator SpawnChicken() {
//         print(Time.time);
//         yield return new WaitForSeconds(2);
//         print(Time.time);

// 		Rigidbody instantiatedChicken = Instantiate (chicken, transform.position, transform.rotation) as Rigidbody;
// 		instantiatedChicken.velocity = transform.TransformDirection (new Vector3 (0,0,speed));
//     }
// }






// void Update () {

// if (dummyVar == 1){
		
		//Instatiate has three variables (object it will instatiate, 3D position, rotation of the object)
		//as Rigidbody converts the object to a Rigidbody for use with C#

		// instantiatedChicken.velocity = transform.TransformDirection (new Vector3 (0,0,speed));
// 	}

// }

// IEnumerator SpawnChicken () {
// 		yield return new WaitForSeconds (5);
// }




