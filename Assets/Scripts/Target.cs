using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Target : MonoBehaviour {
	public Text scoreText;
	public Text clearText;

	private int hp;
	private bool alive;

	// Use this for initialization
	void Start () {
		hp = 100;
		alive = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (alive) {
			hp -= 10;
			if (hp == 0) {
				alive = false;
				clearText.text = "Clear";
			}
			scoreText.text = "Boss HP : " + hp;
		}
	}
}
