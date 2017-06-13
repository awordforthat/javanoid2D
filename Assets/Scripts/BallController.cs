using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

	private Vector2 velocity;
	private Rigidbody2D rigidbody;

	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody2D> ();
		rigidbody.velocity = new Vector2 (Random.Range(-15, 15)
			, Random.Range(-10, -15));



	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetButtonDown ("Jump")) {
			rigidbody.velocity = new Vector2 (0, 10);
		}
	}
}
