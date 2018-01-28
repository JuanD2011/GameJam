using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour {

    bool levelComplete;
    public GameObject[] buttonRat;
    int activeScene;
    private void Start()
    {
        activeScene = SceneManager.GetActiveScene().buildIndex;
        for (int i = 0; i < activeScene; i++)
        {
            buttonRat[i].SetActive(true);
        }
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
        
    }
    public void LevelSelector()
    {
        SceneManager.LoadScene("LevelSelector");
    }
    private void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            buttonRat[activeScene].SetActive(true);
        }
    }
}
