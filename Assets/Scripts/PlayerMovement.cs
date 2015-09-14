using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float walkSpeed;
	public float JumpSpeed;

	private Rigidbody2D rb;

	public GameObject mario;

	Animator animator;

	// Use this for initialization
	void Awake()
	{
		rb = GetComponent<Rigidbody2D> ();
	}

	void Start (){
		animator = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {
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

	void onCollisionEnter2D(Collision2D coll){
		Debug.Log ("ik werk nu voor de if statement");
		if (coll.gameObject.tag == "block") {
			Debug.Log("ik werk");
			Destroy(mario);
		}
	}
}
