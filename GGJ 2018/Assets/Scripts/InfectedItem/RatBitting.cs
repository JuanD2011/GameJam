using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatBitting : MonoBehaviour
{
    public bool inRange = false;
    public bool iCanInfectate = false;

    IInfectable iInfectable;

    void Start ()
    {

    }

    void Update ()
    {
        Infectated();
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject collisioned = other.gameObject;

        if (collisioned.GetComponent<IInfectable>() != null)
        {
            inRange = true;
            iInfectable = collisioned.GetComponent<IInfectable>();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (inRange)
        {
            inRange = false;
            iCanInfectate = false;
        }
    }

    public void Infectated()
    {
        if (Input.GetButton("Jump") && inRange == true)
        {
            iCanInfectate = true;
            iInfectable.Infect(iCanInfectate);
        }
        else
        {
            if (iCanInfectate)
            {
                iInfectable.Uninfected();
            }
            iCanInfectate = false;
        }
    }
}
