using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour {

	public Camera mainCamera;


	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float horizontalInput = Input.GetAxis("Horizontal");
		float verticalInput = Input.GetAxis("Vertical");
	}
}
