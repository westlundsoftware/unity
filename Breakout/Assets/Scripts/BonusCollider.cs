using UnityEngine;
using System.Collections;

public class BonusCollider : MonoBehaviour {

	public GameObject ball;
	public GameObject bonusExplosion;

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag.CompareTo ("Player") == 0) {

			Instantiate (ball, transform.position, Quaternion.identity);
			// give bonus
			Instantiate (bonusExplosion, transform.position, Quaternion.identity);
			Destroy (gameObject);
		}

	}
}
