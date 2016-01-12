using UnityEngine;
using System;

public class CannonMenu : MonoBehaviour {
	private volatile static string cannon;

	public string value;

	void Update() {
		if (CannonMenu.getCannon () == value) {
			gameObject.GetComponent<SpriteRenderer> ().color = Color.black;
		} else {
			gameObject.GetComponent<SpriteRenderer> ().color = Color.white;
		}
	}

	void OnMouseDown() {
		cannon = value;
	}

	public static string getCannon() {
		if (cannon == null) {
			cannon = "Normal";
		}
		return cannon;
	}

	public static void useCannon(string value) {
		cannon = value;
	}
}

