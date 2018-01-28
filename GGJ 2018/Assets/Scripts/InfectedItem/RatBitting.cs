using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RatBitting : MonoBehaviour
{
    public bool inRange = false;
    public bool iCanInfectate = false;
	public GameObject infectateText;

    IInfectable iInfectable;
    
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
			infectateText.SetActive (true);
        }
        else
        {
            if (iCanInfectate)
            {
                iInfectable.Uninfected();
            }
            iCanInfectate = false;
			infectateText.SetActive (false);
        }
    }
}
