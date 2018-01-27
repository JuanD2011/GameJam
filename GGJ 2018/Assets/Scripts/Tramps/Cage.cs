using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cage : MonoBehaviour {
	
	void Start () {
		Invoke ("Destroy", GameObject.FindGameObjectWithTag ("Player").GetComponent<Rat> ().tramp);
	
	}
	
	// Update is called once per frame

	void Destroy(){
		Destroy (gameObject);
	}
}
