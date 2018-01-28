using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatMovement : MonoBehaviour {
	private CharacterController charController;

	private float velMovement;
	float velRotax = 5f;
	float velRotay = 5f;

	void Start () {
		charController = GetComponent<CharacterController>();
	}
  
  void Update ()
    {
		velMovement = gameObject.GetComponent<Rat>(). velMovement;
        Move();
		if (!gameObject.GetComponent<Rat> ().muerte) {
			float h = velRotax * Input.GetAxis ("Mouse X");
			//float v = velRotay * Input.GetAxis ("Mouse Y");

			transform.Rotate (0, h, 0);
		}
	}

    void Move()
    {
		GetComponentInChildren<Animator>().SetFloat("speed", 0.0f);
		if (!gameObject.GetComponent<Rat>().classicTrampBool && !gameObject.GetComponent<Rat>().cageTramp && !gameObject.GetComponent<Rat>().muerte) {
			float sentidoX = Input.GetAxisRaw("Horizontal");
			float sentidoZ = Input.GetAxisRaw("Vertical");
			if (Input.GetButton("Vertical")) {
				charController.Move((transform.forward).normalized * velMovement * Time.deltaTime * sentidoZ);
				GetComponentInChildren<Animator>().SetFloat("speed", 1.0f);
			}
			if (Input.GetButton("Horizontal")) {
				charController.Move((transform.right).normalized * velMovement * Time.deltaTime * sentidoX);
				GetComponentInChildren<Animator>().SetFloat("speed", 1.0f);
			}



			//charController.Move ((new Vector3 (sentidoX, 0.0f, sentidoZ)).normalized * velMovement * Time.deltaTime);
		}
    }

	void rotar(){
	

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
