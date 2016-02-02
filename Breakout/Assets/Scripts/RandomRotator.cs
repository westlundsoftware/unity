using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour {

	public float tumble;
	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		Vector3 v = new Vector3 (0, 20, 20);
		rb.angularVelocity = v * tumble;
	}
}
