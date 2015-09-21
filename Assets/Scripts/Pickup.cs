using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour
{
	//functie is virtual zo dat die ge override kan worden
	public virtual void PlayerHit(PlayerMovement _GO)
	{
		Debug.Log ("waarom doet hij et nie");
	}
	
	void OnTriggerEnter2D(Collider2D coll)
	{
		var l_player = coll.gameObject.GetComponent<PlayerMovement>();//check of de collider gameobject wel onze speler is
		if (l_player != null)//IS dit NIET null dan hebben we de collider van de speler
		{
			PlayerHit(l_player);
			Debug.Log ("ik doe het");
		}
	}
}
