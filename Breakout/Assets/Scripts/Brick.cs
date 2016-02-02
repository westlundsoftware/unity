using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public GameObject explosion;
	public GameObject bonus;

	public void Start()
	{
	}

	void OnCollisionEnter(Collision other)
	{
		if (bonus != null) {
			Instantiate (bonus, transform.position, Quaternion.identity);
		}

		GameManager.instance.DestroyBrick (other);
		Instantiate (explosion, transform.position, Quaternion.identity);

		Destroy (gameObject);


	}
}
