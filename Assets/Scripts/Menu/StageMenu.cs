using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StageMenu : MonoBehaviour {
	private volatile static string stage;

	public string value;

	void OnMouseDown() {
		stage = value;
		Debug.Log (stage);
		Application.LoadLevel ("game"); 
	}

	public static string getStage() {
		if (stage == null) {
			stage = "Stage2";
		}
		return stage;
	}
}
