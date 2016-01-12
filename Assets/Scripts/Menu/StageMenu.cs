using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class StageMenu : MonoBehaviour {
	private volatile static string stage;

	public string value;

	void OnMouseDown() {
		stage = value;
		SceneManager.LoadScene ("game");
	}

	public static string getStage() {
		if (stage == null) {
			stage = "Stage5";
		}
		return stage;
	}
}
