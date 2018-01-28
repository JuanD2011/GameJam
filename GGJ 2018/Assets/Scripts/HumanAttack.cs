using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanAttack : MonoBehaviour {

	public GameObject gameover;
	void OnCollisionEnter(Collision other) {

		if (other.gameObject.tag == "Player") {
			other.gameObject.GetComponent<Rat> ().muerte=true;
			gameover.SetActive (true);
		}
	}
}
