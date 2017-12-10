using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

public Rigidbody projectile;
public float speed = 20f;
public float lifetime = 3.0f;

public AudioSource gunShot;




void Update () {

	if (Input.GetButtonDown("Fire1")) {
		Rigidbody instantiatedProjectile = Instantiate (projectile, transform.position, transform.rotation) as Rigidbody;
		//Instatiate has three variables (object it will instatiate, 3D position, rotation of the object)
		//as Rigidbody converts the object to a Rigidbody for use with C#

		instantiatedProjectile.velocity = transform.TransformDirection (new Vector3 (0,0,speed));

		AudioSource shoot = GetComponent<AudioSource>();
		shoot.Play();
	}
}


}

// public GameObject bulletPrefab;
// public Transform bulletSpawn;


// void Update () {
// 	if (Input.GetKeyDown(KeyCode.Space)) {
// 		Fire();
// 	}
// }

// void Fire () {
// 	var bullet = (GameObject)Instantiate (bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
// 	bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 6;
// 	Destroy(bullet, 2.0f);

// }


// public Rigidbody projectile; 

// public Transform spawnPoint;
// public int shootSpeed;


// void Update () {

// 	if(Input.GetButtonDown("Fire1")) {
// 		Rigidbody clone;
// 		clone = (Rigidbody) Instantiate (projectile, spawnPoint.position, projectile.rotation);
// 		clone.velocity = spawnPoint.TransformDirection (Vector3.forward * shootSpeed);
// 	}

// }


