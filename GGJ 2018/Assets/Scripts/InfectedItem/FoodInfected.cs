using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodInfected : MonoBehaviour, IInfectable
{

    public float timeToFoodGetInfected = 4f;
    private float time = 0f;

    bool infected = false;

    public void Infect(bool _infected)
    {
        if (_infected == true)
        {
            time += Time.deltaTime;

            if (time > timeToFoodGetInfected)
            {
                infected = true; // Infection Complete
            }
        }
    }

    public void Uninfected()
    {
        time = 0f;
    }
}
