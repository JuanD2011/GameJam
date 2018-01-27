using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfectableItems : MonoBehaviour, IInfectable
{

    public float timeToItemGetInfected = 3f;
    public int percentageOfItem = 5;

    public float time = 0f;

    public bool infected = false;

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
