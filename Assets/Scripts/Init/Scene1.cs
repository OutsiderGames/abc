using UnityEngine;
using System.Collections;

public class Scene1 : MonoBehaviour {
	public GameObject ballPrefab;

	// Use this for initialization
	void Start () {
		BallConfig[] configs = new BallConfig[]{new BallConfig(3, 0, 0, -10), new BallConfig(6, 0, 0, 10)};
		foreach(BallConfig config in configs) {
			GameObject ball = MonoBehaviour.Instantiate(ballPrefab) as GameObject;
			ball.transform.position = config.position;
			ball.GetComponent<Rigidbody2D>().velocity = config.velocity;
			ball.GetComponents<CircleCollider2D>()[0].enabled = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
