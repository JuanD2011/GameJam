using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToLevelMenu : MonoBehaviour
{

    public void BackLevelMenu()
    {
        SceneManager.LoadScene("LevelSelector");
    }
}
