using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfectableItems : MonoBehaviour, IInfectable
{

    public float timeToItemGetInfected = 3f;
    public int percentageOfItem = 5;
	public ParticleSystem particula;
	public ParticleSystem.MainModule mainn;
    public float time = 0f;

    public bool infected = false;
	void start(){
		particula = GetComponentInChildren<ParticleSystem> ();

	}

    public void Infect(bool _infected)
    {
        if (infected)
        {
            return;
        }

        if (_infected == true)
        {
            time += Time.deltaTime;

            if (time > timeToItemGetInfected)
            {
                infected = true; // Infection Complete
				particula.startColor = Color.red;
				//mainn = particula.GetComponent<ParticleSystem.MainModule> ();
				//mainn.startColor = Color.red;

                PercentageOfInfection.percentage = Mathf.Min(PercentageOfInfection.percentage + percentageOfItem, 100);
                    
            }
            else
            {
                infected = false;
            }
        }

        
    }

    public void Uninfected()
    {
        time = 0f;
    }
}
