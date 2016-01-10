using UnityEngine;
using System.Collections;

public class Init : MonoBehaviour {
	public AbcConfig config;

	void Start() {
		config = GameObject.Find (Menu.scene).GetComponent<AbcConfig> ();
		config.initialize ();
	}

	void Update() {
	}
}

