using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

public int damage = 1;
public int time = 5;

void Start () {
	StartCoroutine(DestroyBullet());
}

void OnCollisionEnter(Collision other)
{
	var hit = other.gameObject;
	var health = hit.GetComponent<Wolf_Health>();

	if(health != null) {
		health.TakeDamage(damage);

	if (other.gameObject.name == "Wolf") {
		Destroy(gameObject);
	}
}
}

IEnumerator DestroyBullet() {
	yield return new WaitForSeconds(time);
	Destroy(gameObject);

	//If want to destroy the object you would like to hit ... other.gameObject.
	}
}

