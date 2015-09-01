using UnityEngine;
using System.Collections;

public class PlayMenu : MonoBehaviour {

	public void ChangeToScene (int sceneToChangeTo){

		Application.LoadLevel (sceneToChangeTo);
	}
	
}
