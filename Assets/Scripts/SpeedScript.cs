using UnityEngine;
using System.Collections;

public class SpeedScript : MonoBehaviour {

	public GameObject[] obj;
	public float speed;

	// Use this for initialization
	void Start () {
		Speed ();
	}
	
	// Update is called once per frame
	void Speed () {
		//transform.position -= new Vector3 (speed * Time.deltaTime);
	}
}
