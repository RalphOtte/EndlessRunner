using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float walkSpeed = 0.2f;
	public float JumpSpeed = 10.0f;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			transform.position -= new Vector3 (walkSpeed * Time.deltaTime, 0.0f, 0.0f);
		}
		
		if (Input.GetKey (KeyCode.D)) {
			transform.position += new Vector3 (walkSpeed * Time.deltaTime, 0.0f, 0.0f);
		}
		/*
		if (Input.GetKey (KeyCode.Space)) {
			Jump();
		}
		*/
	}
	/*
	void Jump (){
		Rigidbody.AddForce (Vector2.up * JumpSpeed);
	}
	*/
}
