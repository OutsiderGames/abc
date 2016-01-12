using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class Target : MonoBehaviour {
	[SerializeField]
	private Texture2D emptyTex;
	[SerializeField]
	private Texture2D fullTex;
	
	private int maxHp;
	private int hp;
	private bool alive;
	private float minX;
	private float maxX;
	private float minY;
	private float maxY;

	private Animator animator;

	private Vector2 screenPosition;
	private float energy = 1f;

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

		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 barPos = new Vector2 (transform.position.x - 3f, transform.position.y + 2f);
		screenPosition = Camera.main.WorldToScreenPoint(barPos);
		screenPosition.y = Screen.height - screenPosition.y;
	}

	void OnGUI() {
		Vector2 pos = screenPosition;
		Vector2 size = new Vector2 (100, 15);

		//draw the background:
		GUI.BeginGroup(new Rect(pos.x, pos.y, size.x, size.y));
		GUI.Box(new Rect(0,0, size.x, size.y), emptyTex);

		//draw the filled-in part:
		GUI.BeginGroup(new Rect(0,0, size.x * energy, size.y));
		GUI.Box(new Rect(0,0, size.x, size.y), fullTex);
		GUI.EndGroup();
		GUI.EndGroup();
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (alive) {
			hp -= 10;
			if (hp == 0) {
				alive = false;
				Application.LoadLevel ("result"); 
			}

			animator.SetBool ("hit", true);
			energy = (float)hp / (float)maxHp;
		}
		other.gameObject.SetActive (false);
	}
}
