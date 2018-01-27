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
		if (!gameObject.GetComponent<Rat> ().classicTrampBool && !gameObject.GetComponent<Rat> ().cageTramp ) {
			float sentidoX = Input.GetAxisRaw("Horizontal");
			float sentidoZ = Input.GetAxisRaw("Vertical");

			charController.Move ((new Vector3 (sentidoX, 0.0f, sentidoZ)).normalized * velMovement * Time.deltaTime);
		}
    }

	void OntriggerEnter(Collider other) {
	
		if (other.gameObject.tag == "Poison") {
			velMovement /= 2;
		}
	}
}
