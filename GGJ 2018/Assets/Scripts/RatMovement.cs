using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatMovement : Rat
{
	void Update ()
    {
        Move();
	}

    void Move()
    {
        float sentidoX = Input.GetAxis("Horizontal") * velMovement;
        float sentidoZ = Input.GetAxis("Vertical") * velMovement;
        transform.position += new Vector3(sentidoX, 0, sentidoZ) * Time.deltaTime;
    }
}
