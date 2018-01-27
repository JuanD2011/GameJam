using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpInvicibility : MonoBehaviour {

	void OnCollisionEnter(Collision other) {

		if (other.gameObject.tag == "Player") {
			other.gameObject.GetComponent<Rat> ().invicibilitybool = true;
			other.gameObject.SendMessage ("Invicibility");
			Destroy (gameObject);
		}
	}
}
