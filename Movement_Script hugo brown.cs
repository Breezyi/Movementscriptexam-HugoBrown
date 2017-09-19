using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Script : MonoBehaviour {

	public bool wPressed;
	public bool sPressed;
	public bool aPressed;
	public bool dPressed;
	public bool spacePressed;

	public float movementSpeed;
	public float jumpHeight;

	void Update () {

		wPressed = Input.GetKey (KeyCode.W);
		sPressed = Input.GetKey (KeyCode.S);
		aPressed = Input.GetKey (KeyCode.A);
		dPressed = Input.GetKey (KeyCode.D);

	}
	private void FixedUpdate () {
		if (wPressed == true) {
			GetComponent<Rigidbody> ().AddForce (Vector3.forward * movementSpeed, ForceMode.VelocityChange);
		}

		if (sPressed == true) {
			GetComponent<Rigidbody> ().AddForce (-Vector3.forward * movementSpeed, ForceMode.VelocityChange);
		}

		if (aPressed == true) {
			GetComponent<Rigidbody> ().AddForce (-Vector3.right * movementSpeed, ForceMode.VelocityChange);
		}

		if (dPressed == true) {
			GetComponent<Rigidbody> ().AddForce (Vector3.right * movementSpeed, ForceMode.VelocityChange);
		}

			if (spacePressed ==true) {
			GetComponent<Rigidbody> ().AddForce (Vector3.up * jumpHeight);
		}
	 }
}
