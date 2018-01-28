using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUPVelocidad : MonoBehaviour {

	void OnCollisionEnter(Collision other) {
	
		if (other.gameObject.tag == "Player") {
			other.gameObject.GetComponent<Rat> ().velMovement *= 1.5f;
			other.gameObject.SendMessage ("Velocidad");
			Destroy (gameObject);
		}
	}
}
