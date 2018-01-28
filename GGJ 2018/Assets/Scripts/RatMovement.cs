using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatMovement : MonoBehaviour {
	private CharacterController charController;

	private float velMovement;
	float velRotax = 5f;
	float velRotay = 5f;

    AudioSource poisonSound;

	void Start () {
		charController = GetComponent<CharacterController>();
        poisonSound = transform.Find("Poison").GetComponent<AudioSource>();
	}
  
  void Update ()
    {
		velMovement = gameObject.GetComponent<Rat>(). velMovement;
        Move();

		float h = velRotax * Input.GetAxis ("Mouse X");
		float v = velRotay * Input.GetAxis ("Mouse Y");

		transform.Rotate (0, h, 0);
	}

    void Move()
    {
		if (!gameObject.GetComponent<Rat> ().classicTrampBool && !gameObject.GetComponent<Rat> ().cageTramp && !gameObject.GetComponent<Rat> ().muerte) {
			float sentidoX = Input.GetAxis ("Horizontal");
			float sentidoZ = Input.GetAxis ("Vertical");

			charController.Move ((new Vector3 (sentidoX, 0.0f, sentidoZ)).normalized * velMovement * Time.deltaTime);
		}
    }

	void rotar(){
	

	}

	void OnTriggerEnter(Collider other) {
		
		if (other.gameObject.tag == "Poison") {
			gameObject.GetComponent<Rat>(). velMovement/=gameObject.GetComponent<Rat>(). poison;
            poisonSound.mute = false;
		}
	}

	void OnTriggerExit(Collider other) {

		if (other.gameObject.tag == "Poison") {
			gameObject.GetComponent<Rat>(). velMovement*=gameObject.GetComponent<Rat>(). poison;
            poisonSound.mute = true;
		}
	}
}
