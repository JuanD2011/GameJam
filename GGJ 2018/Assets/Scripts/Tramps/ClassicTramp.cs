using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassicTramp : MonoBehaviour {

	public GameObject gameover;
	private bool used = false;

	void OnCollisionEnter(Collision other) {

		if ((other.gameObject.tag == "Player") && !used && !other.gameObject.GetComponent<Rat>().invicibilitybool) {
			other.gameObject.GetComponent<Rat> ().muerte = true;
			other.gameObject.SendMessage ("ClassicTramp");
			used = true;
			gameover.SetActive (true);
		}
}
}
