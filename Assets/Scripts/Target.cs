using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using System.Collections;

public class Target : MonoBehaviour {
	private int maxHp;
	private int hp;
	private bool alive;
	private float minX;
	private float maxX;
	private float minY;
	private float maxY;

	private Animator animator;

	private float energy = 1f;
	private GameObject fillBarGameObject;
	private GameObject energyBarGameObject;

	private float barXPositionAdject = - 2f;
	private float barYPositionAdject = 1.8f;

	// Use this for initialization
	void Start () {
		AbcConfig config = (AbcConfig)Activator.CreateInstance(Type.GetType (StageMenu.getStage ()));
		hp = config.hp;
		maxHp = config.hp;
		alive = true;
		Hashtable hash = new Hashtable ();
		hash ["looptype"] = config.loopType;
		hash ["easetype"] = config.easeType;
		hash ["speed"] = config.speed;
		hash ["path"] = config.path;
		this.gameObject.transform.position = config.path [0];
		iTween.MoveTo (this.gameObject, hash);

		animator = GetComponent<Animator> ();

		// create energy bar

		energyBarGameObject = Instantiate (Resources.Load ("EnergyBar", typeof(GameObject))) as GameObject;
		energyBarGameObject.transform.parent = gameObject.transform;
		energyBarGameObject.transform.position = new Vector3 (transform.position.x + barXPositionAdject , transform.position.y + barYPositionAdject, 0);
		energyBarGameObject.name = "TargetEnergyBar";
		fillBarGameObject = GameObject.Find ("TargetEnergyBar/EnergyFillBar");
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (alive) {
			hp -= 10;
			energy = ((float)hp / (float)maxHp);
			fillBarGameObject.transform.localScale = new Vector3 (energy, 1, 1);
			if (hp == 0) {
				alive = false;
				SceneManager.LoadScene ("result");
			}

			animator.SetBool ("hit", true);
		}
		other.gameObject.SetActive (false);
	}
}
