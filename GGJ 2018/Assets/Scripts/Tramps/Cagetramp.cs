using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cagetramp : MonoBehaviour {

	private bool used = false;
	public GameObject jaula;

	void OnCollisionEnter(Collision other) {

		if ((other.gameObject.tag == "Player") && !used && !other.gameObject.GetComponent<Rat>().invicibilitybool) {
			other.gameObject.GetComponent<Rat> ().cageTramp = true;
			other.gameObject.SendMessage ("CageTramp");
			Instantiate (jaula, new Vector3(other.transform.position.x, other.transform.position.y + 4, other.transform.position.z), other.transform.rotation);
			used = true;
			Destroy (gameObject);
		}
	}
}
