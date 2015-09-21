using UnityEngine;
using System.Collections;

public class DeathScript : Pickup {

	public override void PlayerHit(PlayerMovement _GO)
	{
		base.PlayerHit(_GO);//roep de basis classe nog wel aan(dus de playerhit in pickup)
		//voeg hier code toe zo dat de speler zijn score omhoog gaat
		_GO.m_score -= 100;
		Destroy (this.gameObject);
		Application.LoadLevel (4);
	}
}
