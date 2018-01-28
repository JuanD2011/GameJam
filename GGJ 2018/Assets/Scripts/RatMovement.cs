using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatMovement : MonoBehaviour {
	private CharacterController charController;

	private float velMovement;

	void Start () {
		charController = GetComponent<CharacterController>();
	}
  
  void Update ()
    {
		velMovement = gameObject.GetComponent<Rat>(). velMovement;
        Move();
	}

    void Move()
    {
		if (!gameObject.GetComponent<Rat> ().classicTrampBool && !gameObject.GetComponent<Rat> ().cageTramp && !gameObject.GetComponent<Rat> ().muerte) {
			float sentidoX = Input.GetAxis ("Horizontal");
			float sentidoZ = Input.GetAxis ("Vertical");

			charController.Move ((new Vector3 (sentidoX, 0.0f, sentidoZ)).normalized * velMovement * Time.deltaTime);
		}
    }

	void OnTriggerEnter(Collider other) {
		
		if (other.gameObject.tag == "Poison") {
			gameObject.GetComponent<Rat>(). velMovement/=gameObject.GetComponent<Rat>(). poison;
		}
	}

	void OnTriggerExit(Collider other) {

		if (other.gameObject.tag == "Poison") {
			gameObject.GetComponent<Rat>(). velMovement*=gameObject.GetComponent<Rat>(). poison;
		}
	}
}
