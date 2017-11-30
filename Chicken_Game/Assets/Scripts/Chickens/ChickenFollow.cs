using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenFollow : MonoBehaviour {

	public Transform target;
	public Transform myTransform;


void Start () {

target = GameObject.FindWithTag("Player").transform;
//Allows chicken to find player, or else it just wanders off into the void.

}

void FixedUpdate () {

transform.LookAt (target);
transform.Translate (Vector3.forward * Time.deltaTime);

/*Set RigidBody on Chicken, set mass to .02 or something small, and set player mass higher
to keep chicken from pushing player. Mesh Colliders on both Player and Chicken keep them
from passing through one another.*/


}




}

