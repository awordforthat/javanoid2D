using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

	private Vector2 velocity;
	private Rigidbody2D rigidbody;
	public float maxSpeed;

	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody2D> ();
		rigidbody.velocity = new Vector2 (Random.Range(-maxSpeed, maxSpeed)
			, Random.Range(-1, -maxSpeed));



	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetButtonDown ("Jump")) {
			rigidbody.velocity = new Vector2 (0, 10);
		}
	}
}
