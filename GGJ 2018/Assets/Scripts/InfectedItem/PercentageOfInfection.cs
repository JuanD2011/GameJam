using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PercentageOfInfection : MonoBehaviour
{
    public static float percentage;
    public Text percentageCounter;
    public Text winText;

    public bool winCondition = false;


    GameObject buttonBackToLevelMenu;

    private void Start()
    {
		percentage = 0f;
        winText.gameObject.SetActive(false);

        buttonBackToLevelMenu = GameObject.Find("BackToLevelMenu");

        buttonBackToLevelMenu.gameObject.SetActive(false);
    }

    private void Update()
    {
        percentageCounter.text = " " + percentage.ToString();
        WinCondition();
    }

    public void WinCondition()
    {
        if (percentage >= 100)
        {
            winCondition = true;

            winText.gameObject.SetActive(true);
            buttonBackToLevelMenu.gameObject.SetActive(true);

            if (winCondition)
            {
                Time.timeScale = 0;
            }
        }
    }

}
