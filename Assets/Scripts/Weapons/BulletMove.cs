using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour {

	public float speed;
	private Rigidbody myRb;

	// Use this for initialization
	void Start () {

		myRb = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		myRb.velocity =  transform.forward * speed;

	}
}
