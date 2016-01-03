using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Target : MonoBehaviour {
	public Text scoreText;

	private int score;

	// Use this for initialization
	void Start () {
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other) {
		score += 100;
		scoreText.text = "Score : " + score;
	}
}
