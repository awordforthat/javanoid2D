using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour {

	public int maxSpeed;
	private Vector3 movement;
	private Rigidbody2D paddleRigidBody;

	// Use this for initialization
	void Start () {
		paddleRigidBody = GetComponent<Rigidbody2D> ();
		movement = new Vector3 ();
	}
	
	// Update is called once per frame
	void Update () {
		movement.Set(Input.GetAxis("Horizontal"), 0, 0);
		movement = movement.normalized * maxSpeed * Time.deltaTime;

		paddleRigidBody.MovePosition (transform.position + movement);
	}
}
