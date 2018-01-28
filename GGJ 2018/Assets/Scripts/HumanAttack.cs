using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanAttack : MonoBehaviour {

    AudioSource mStomp;

	public GameObject gameover;

    public delegate void Crush();
    public static event Crush OnStomp;

    void Start()
    {
        mStomp = GetComponent<AudioSource>();
    }
	void OnCollisionEnter(Collision other) {

		if (other.gameObject.tag == "Player")
        {
            if(!mStomp.isPlaying)
            {
                mStomp.Play();
                OnStomp();
            }       
			other.gameObject.GetComponent<Rat> ().muerte=true;
			gameover.SetActive (true);
		}
	}
}
