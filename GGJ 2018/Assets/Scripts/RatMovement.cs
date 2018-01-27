using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatMovement : MonoBehaviour {
	private CharacterController charController;

	public float velMovement = 3f;

	void Start () {
		charController = GetComponent<CharacterController>();
	}
  
  void Update ()
    {
        Move();
	}

    void Move()
    {
        float sentidoX = Input.GetAxis("Horizontal");
        float sentidoZ = Input.GetAxis("Vertical");
		charController.Move((new Vector3(sentidoX, 0.0f, sentidoZ)).normalized * velMovement * Time.deltaTime);
    }
}
