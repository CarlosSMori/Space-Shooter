using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float speed = 5f, bankingValue = 90f ;
	public Transform visualChild;
	private Camera cam;
	private Rigidbody myRb;
	private float distance;
	private Vector3 velocity, lastPosition, rotation, touchPos, screenToWorld;


	// Use this for initialization
	void Start () {

		cam = Camera.main;
		myRb = GetComponent<Rigidbody>();

		distance = (cam.transform.position - transform.position).y;
	}
	
	// Update is called once per frame
	void Update () {

		velocity = transform.position - lastPosition;
		Move();
		lastPosition = transform.position;
		
	}
	void Move(){

		touchPos = Input.mousePosition;
		touchPos.z = distance;

		screenToWorld = cam.ScreenToWorldPoint(touchPos);

		Vector3 movement = Vector3.Lerp(transform.position, screenToWorld, speed * Time.deltaTime);

		myRb.MovePosition(movement);

		rotation.z = velocity.x * bankingValue;
		myRb.MoveRotation(Quaternion.Euler(rotation));
	}
}
