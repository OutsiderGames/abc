using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Menu : MonoBehaviour {
	private volatile static string scene;

	// Use this for initialization
	void Start () {
		scene = GetComponent<Text> ().text;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonUp (0)) {
			Application.LoadLevel ("game"); 
		}
	}

	public static string getStage() {
		if (scene == null) {
			scene = "Scene1";
		}
		Debug.Log (scene);
		return scene;
	}
}
