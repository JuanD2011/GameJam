using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rat : MonoBehaviour
{
    public float velMovement = 3f;
    public float perception = 10f;
    public float invicibility = 10f;
    public float invisibility = 10f;
	public float classicTramp = 4f;
	public float poison = 4f;
	public float tramp = 8f;

	public bool invicibilitybool = false;
	public bool invisibilitybool = false;
	public bool classicTrampBool = false;
	public bool cageTramp = false;


	void Update () {
	}

	public void Velocidad () {
		Invoke ("ApagarVelocidad", perception);
	}

	private void ApagarVelocidad(){
		velMovement /= 1.5f;
	}

	public void Invicibility () {
		Invoke ("ApagarInvicibility", invicibility);
	}

	private void ApagarInvicibility(){
		invicibilitybool = false;
	}

	public void Invisibility () {
		Invoke ("ApagarInvisibility", invisibility);
	}

	private void ApagarInvisibility(){
		invisibilitybool = false;
	}

	public void ClassicTramp () {
		Invoke ("ApagarClassicTramp", classicTramp);
	}

	private void ApagarClassicTramp(){
		classicTrampBool = false;
	}

	public void CageTramp () {
		Invoke ("ApagarCageTramp", tramp);
	}

	private void ApagarCageTramp(){
		cageTramp = false;
	}
}
