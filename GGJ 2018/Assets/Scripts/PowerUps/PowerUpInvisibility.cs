using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpInvisibility : MonoBehaviour {

	void OnCollisionEnter(Collision other) {

		if (other.gameObject.tag == "Player") {
			other.gameObject.GetComponent<Rat> ().invisibilitybool = true;
			other.gameObject.SendMessage ("Invisibility");
			Destroy (gameObject);
		}
	}
}
