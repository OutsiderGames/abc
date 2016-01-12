using UnityEngine;
using System;
using System.Collections;

public class Init : MonoBehaviour {
	[SerializeField]
	private GameObject[] target;

	private AbcConfig config;
	private int bullet;
	private int ballBucketSize;
	private BallConfig[] configs;

	void Start() {
		AbcConfig config = (AbcConfig)Activator.CreateInstance(Type.GetType (StageMenu.getStage ()));
		bullet = config.bullet;
		ballBucketSize = config.ballBucketSize;
		configs = config.configs;
		initialize ();
	}

	void Update() {
	}

	public void initialize() {
		foreach(BallConfig config in configs) {
			GameObject ball = Instantiate(Resources.Load("Balls/ball_" + config.color ,typeof(GameObject))) as GameObject;
			ball.transform.position = config.position;
			ball.GetComponent<Ball> ().color = config.color;
			ball.GetComponent<Ball> ().disturb = true;
			ball.GetComponent<Rigidbody2D>().velocity = config.velocity;
			ball.GetComponent<Rigidbody2D>().mass = config.mass;
			ball.GetComponents<CircleCollider2D>()[0].enabled = true;
		}

		int targetIdx = UnityEngine.Random.Range (0, target.Length);
		Instantiate(target [targetIdx]);
	}
}

