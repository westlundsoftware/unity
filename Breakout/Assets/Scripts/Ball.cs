using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	Rigidbody rb;
	bool ballInPlay = false;
	public float initialVelocity = 100f;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1") && ballInPlay == false) {
			ballInPlay = true;
			transform.parent = null;
			rb.isKinematic = false;

			rb.AddForce(new Vector3(initialVelocity, 0, initialVelocity));
		}
	}
}
