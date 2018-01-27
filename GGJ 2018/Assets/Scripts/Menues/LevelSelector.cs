using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour {
	private string levelId;

	public GameObject[] stars;

	void Start() {
		gameObject.SetActive(false);

		AddListeners();
	}

	private void AddListeners() {
		Button button = GameObject.Find("btnLevel1").GetComponent<Button>();
		button.onClick.AddListener(() => OnSelectLevel("Level1", 1, "Someone's house"));

		button = GameObject.Find("btnLevel2").GetComponent<Button>();
		button.onClick.AddListener(() => OnSelectLevel("Level2", 1, "Your neighbor"));

		button = GameObject.Find("btnLevel3").GetComponent<Button>();
		button.onClick.AddListener(() => OnSelectLevel("Level3", 2, "Level 03"));

		button = GameObject.Find("btnLevel4").GetComponent<Button>();
		button.onClick.AddListener(() => OnSelectLevel("Level4", 2, "Out of Ideas"));

		button = GameObject.Find("btnLevel5").GetComponent<Button>();
		button.onClick.AddListener(() => OnSelectLevel("Level5", 3, "Yup"));
	}

	public void OnSelectLevel(string levelId, int difficult, string levelName) {
		if (gameObject.activeSelf) {
			return;
		}

		this.levelId = levelId;

		gameObject.SetActive(true);

		(GameObject.Find("lblLevelName").GetComponent<Text>()).text = levelName;

		for (int i = 0; i < 3; i++) {
			stars[i].SetActive(i < difficult);
		}
	}

	public void CloseSelectLevel() {
		gameObject.SetActive(false);
	}

	public void GotoLevel() {
		SceneManager.LoadScene(levelId);
	}
}
