using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUPVelocidad : MonoBehaviour
{
    public delegate void PU();
    public static event PU OnPU;

	void OnCollisionEnter(Collision other)
    {
	
		if (other.gameObject.tag == "Player")
        {
            OnPU();
			other.gameObject.GetComponent<Rat> ().velMovement *= 1.5f;
			other.gameObject.SendMessage ("Velocidad");
			Destroy (gameObject);
		}
	}
}
