using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	Vector3 playerPos;
	public float Speed = 0.1f;
	public float xMin, xMax;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		float posX= transform.position.x + (Input.GetAxis ("Horizontal")*Speed);


		transform.position = new Vector3(Mathf.Clamp(posX, xMin,xMax), transform.position.y, transform.position.z);

	}
}
