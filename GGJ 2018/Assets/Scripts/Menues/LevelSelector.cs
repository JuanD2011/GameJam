using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour {

	public void onSelectLevel(string levelId) {
		SceneManager.LoadScene(levelId);
	}
}
