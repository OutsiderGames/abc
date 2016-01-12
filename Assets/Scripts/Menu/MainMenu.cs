using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenu : MonoBehaviour {
	void OnMouseDown() {
		SceneManager.LoadScene ("menu");
	}
}
