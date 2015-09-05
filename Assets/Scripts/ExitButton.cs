using UnityEngine;
using System.Collections;

public class ExitButton : MonoBehaviour {

	void Update() {
		if (Input.GetKey(KeyCode.Escape)){
			Application.Quit();
		
		}
	}
}