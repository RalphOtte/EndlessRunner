using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float m_score = 0;

	public float walkSpeed;
	public float JumpSpeed;
	public float acceleration;

	private Rigidbody2D rb;
	private bool touchingPlatform;

	Animator animator;

	// Use this for initialization
	void Awake()
	{
		rb = GetComponent<Rigidbody2D> ();
	}

	void Start (){
		animator = GetComponent<Animator> ();
	}
	/*
	void FixedUpdate (){
		if (touchingPlatform) {
				rb.AddForce(acceleration, 0f,ForceMode2D.Force);
		}
	}
	*/
	void OnCollisionEnter (){
		touchingPlatform = true;
	}

	void OnCollisionExit (){
		touchingPlatform = false;
	}

	// Update is called once per frame
	void Update (){
		if (Input.GetKey (KeyCode.A)) {
			transform.position -= new Vector3 (walkSpeed * Time.deltaTime, 0.0f, 0.0f);
		}
		
		if (Input.GetKey (KeyCode.D)) {
			transform.position += new Vector3 (walkSpeed * Time.deltaTime, 0.0f, 0.0f);
		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			Jump();
			animator.SetInteger ("Jump", 1);
		} else if(Input.GetKeyUp(KeyCode.Space)) {
			animator.SetInteger ("Jump", 0);
		}
	}

	void Jump (){
		rb.AddForce (Vector2.up * JumpSpeed, ForceMode2D.Impulse);
	}
}
