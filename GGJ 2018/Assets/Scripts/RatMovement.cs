using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatMovement : MonoBehaviour {

	float velMovement = 3f;
	float dirX, dirY;
    Transform mTransform;
	void Start () {
        mTransform = GetComponent<Transform>();
	}

	void Update () {
		float sentidoX = Input.GetAxis ("Horizontal") * velMovement;
        float sentidoZ = Input.GetAxis("Vertical") * velMovement;
        mTransform.position += new Vector3(sentidoX, 0, sentidoZ) * Time.deltaTime;
	}


}
