using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour {

	public int maxSpeed;
	private GameObject paddle;

	// Use this for initialization
	void Start () {
		paddle = GetComponent<GameObject> ();
	}
	
	// Update is called once per frame
	void Update () {
		var move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
		transform.position += move * maxSpeed * Time.deltaTime;
	}
}
