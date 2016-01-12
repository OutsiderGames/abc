using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class Target : MonoBehaviour {
	public Text scoreText;

	private int maxHp;
	private int hp;
	private bool alive;
	private float minX;
	private float maxX;
	private float minY;
	private float maxY;

	private Animator animator;

	// Use this for initialization
	void Start () {
		AbcConfig config = (AbcConfig)Activator.CreateInstance(Type.GetType (StageMenu.getStage ()));
		hp = config.hp;
		maxHp = config.hp;
		alive = true;
		Hashtable hash = new Hashtable ();
		hash ["looptype"] = iTween.LoopType.loop;
		hash ["easetype"] = iTween.EaseType.linear;
		hash ["speed"] = config.speed;
		hash ["path"] = config.path;
		iTween.MoveTo (this.gameObject, hash);
		scoreText.text = "Boss HP : " + hp * 100 / maxHp  + "%";

		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (alive) {
			hp -= 10;
			if (hp == 0) {
				alive = false;
				scoreText.text = "Clear";
				Application.LoadLevel ("result"); 
			} else {
				scoreText.text = "Boss HP : " + hp * 100 / maxHp  + "%";
			}

			animator.SetBool ("hit", true);
		}
		other.gameObject.SetActive (false);
	}
}
