using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatBase : Rat
{
    AudioSource ratCrush;
    AudioSource soundPU;

    void Start()
    {
        HumanAttack.OnStomp += Crush;
        PowerUPVelocidad.OnPU += PU;
        ratCrush = transform.Find("Crush").GetComponent<AudioSource>();
        soundPU = transform.Find("PU").GetComponent<AudioSource>();
    }
    
    void Crush()
    {
        ratCrush.Play();
    }
    void PU()
    {
        soundPU.Play();
    }
}
