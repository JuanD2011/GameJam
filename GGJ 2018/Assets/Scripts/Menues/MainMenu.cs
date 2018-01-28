using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void onStartGame() {
        SceneManager.LoadScene(1);
		//SceneManager.LoadScene("LevelSelector");
	}

	public void onLoadCredits() {
		SceneManager.LoadScene("Credits");
	}

	public void onReturnToMenu() {
		SceneManager.LoadScene("MainMenu");
	}
}
