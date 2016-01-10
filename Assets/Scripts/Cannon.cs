using UnityEngine;
using System.Collections;

public class Cannon : MonoBehaviour {
	public GameObject ballPrefab;
	private AbcConfig config;
	private int bullet;
	private int ballBucketSize;

	// Use this for initialization
	void Start () {
		AbcConfig config = GameObject.Find (Menu.scene).GetComponent<AbcConfig>();
		bullet = config.bullet;
		ballBucketSize = config.ballBucketSize;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonUp(0) && bullet > 0) {
			ThrowBall ();
		}
	}

	void ThrowBall() {
		int ballNumber = (int) Random.Range(1, ballBucketSize);
		GameObject ball = Instantiate(Resources.Load("Balls/ball_" + ballNumber ,typeof(GameObject))) as GameObject;
		ball.name = "ball" + bullet--;
		Vector3 position = this.transform.position;
		ball.transform.position = position;
		ball.GetComponent<Rigidbody2D>().velocity = new Vector3(10, 0, 0);
	}
}
