using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {


	public float maxSpeed;
	private Vector2 movement;
	private Rigidbody2D rigidbody;



	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody2D> ();

		rigidbody.velocity = new Vector2 (Random.Range(-1f, 1f)
			, Random.Range(-1, -5f)).normalized * maxSpeed;

	}

	void OnCollisionEnter()
	{
		Debug.Log ("Collided with a wall");
	}
	

}
