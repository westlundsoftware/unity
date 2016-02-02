using UnityEngine;
using System.Collections;

public class DeathZone : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		Destroy (other);

		if (other.tag.CompareTo ("Ball") == 0) {
			GameManager.instance.LostLife ();
		}
	}
}
