using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ConfigMenu : MonoBehaviour {
	void OnMouseDown() {
		SceneManager.LoadScene ("config");
	}
}
