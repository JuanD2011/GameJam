using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassicTramp : MonoBehaviour
{
	private bool used = false;
    AudioSource mAudio;
    
    void Start()
    {
        mAudio = GetComponent<AudioSource>();
    }

	void OnCollisionEnter(Collision other)
    {

        if(!mAudio.isPlaying)
        {
            mAudio.Play();
        }

        if ((other.gameObject.tag == "Player") && !used && !other.gameObject.GetComponent<Rat>().invicibilitybool) {
			other.gameObject.GetComponent<Rat> ().classicTrampBool = true;
			other.gameObject.SendMessage ("ClassicTramp");
			used = true;
		}
    }
}
