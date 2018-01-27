using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poison : MonoBehaviour {

	void OnCollisionStay(Collision other) {

		if ((other.gameObject.tag == "Player") && !other.gameObject.GetComponent<Rat>().invicibilitybool) {
			other.gameObject.GetComponent<Rat> ().velMovement /=2;

		}
	}
	
	}

