using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

	Rigidbody rb;
	public float speed = 1f;

	// Use this for initialization
	void Start () {
		rb = GetComponent < Rigidbody> ();
		rb.velocity = transform.forward * speed;
		//rb.AddForce(new Vector3(speed, 0, speed));
	}

}
