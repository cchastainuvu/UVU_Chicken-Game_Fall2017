using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generic : MonoBehaviour {

//A vector is a point in space. Three dimensional objects have coordinates in X,Y,Z axes.

/*Vector3 is a point in 3D space, three axes. Vector2 is a point in 2D space, X and Y. Used for moving around
but not used for rotation, because rotation is stored in degrees, not units of distance like the Vector3.*/

//When needed Quaternion can be used for point of reference and rotating differently. Euler more accurate.


// Position Variables...

// public float posX;
// public float posY;
// public float posZ;

public Vector3 pos;

//Rotation Variables...

// public float rotX;
// public float rotY;
// public float rotZ;
// public float rotW;
public Quaternion rot;

//Scaling Variables...

// public float x = 1f;
// public float y = 1f;
// public float z = 1f;

public Vector3 scale;

//Floats better, because smaller increments for scale-ability.

void Start () {
	scale = transform.localScale;
}

void Update () {
	// transform.position = new Vector3 (posX,posY,posZ);
	// transform.rotation = new Quaternion (rotX,rotY,rotZ,rotW);
	// transform.localScale = new Vector3 (x,y,z);

	transform.position = pos;
	transform.rotation = rot;
	scale = Vector3.one;

//When referring to transform: position, rotation, and scale.
//rotW established as a pointer for the Quaternion to reference.
//Rotation is essentiall local, while position is global, but must be local to be scaled specifically.
}


}
