using UnityEngine;
using System.Collections;

public class Scene1 : AbcConfig {
	// Use this for initialization
	void Start () {
		bullet = 15;
		ballBucketSize = 3;
		BallConfig[] configs = new BallConfig[]{new BallConfig(3, 0, 0, -10), new BallConfig(6, 0, 0, 10)};
		foreach(BallConfig config in configs) {
			int ballNumber = (int) Random.Range(1, ballBucketSize);
			GameObject ball = Instantiate(Resources.Load("Balls/ball_" + ballNumber ,typeof(GameObject))) as GameObject;
			ball.transform.position = config.position;
			ball.GetComponent<Rigidbody2D>().velocity = config.velocity;
			ball.GetComponents<CircleCollider2D>()[0].enabled = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
