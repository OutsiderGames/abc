using UnityEngine;
using System;
using System.Collections;

public class Init : MonoBehaviour {
	private AbcConfig config;
	private int bullet;
	private int ballBucketSize;
	private BallConfig[] configs;

	void Start() {
		AbcConfig config = (AbcConfig)Activator.CreateInstance(Type.GetType (Menu.getStage ()));
		bullet = config.bullet;
		ballBucketSize = config.ballBucketSize;
		configs = config.configs;
		initialize ();
	}

	void Update() {
	}

	public void initialize() {
		foreach(BallConfig config in configs) {
			int ballNumber = (int) UnityEngine.Random.Range(1, ballBucketSize + 1);
			Debug.Log ("ball number : " + ballNumber);
			GameObject ball = Instantiate(Resources.Load("Balls/ball_" + ballNumber ,typeof(GameObject))) as GameObject;
			ball.transform.position = config.position;
			ball.GetComponent<Ball> ().color = ballNumber;
			ball.GetComponent<Ball> ().disturb = true;
			ball.GetComponent<Rigidbody2D>().velocity = config.velocity;
			ball.GetComponents<CircleCollider2D>()[0].enabled = true;
		}
	}
}

