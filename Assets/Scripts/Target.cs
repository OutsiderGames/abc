using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Target : MonoBehaviour {
	public Text scoreText;
	public Text clearText;

	private int hp;
	private bool alive;
	private float minX;
	private float maxX;
	private float minY;
	private float maxY;

	// Use this for initialization
	void Start () {
		hp = 100;
		alive = true;
		Hashtable hash = new Hashtable ();
		hash ["looptype"] = iTween.LoopType.pingPong;
		hash ["easetype"] = iTween.EaseType.linear;
		hash ["time"] = 2.0f;
		hash ["path"] = new Vector3[]{new Vector3(11, -5, 0), new Vector3(11, 5, 0)};
		iTween.MoveTo (this.gameObject, hash);
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
