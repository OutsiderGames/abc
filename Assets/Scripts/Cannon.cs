using UnityEngine;
using System.Collections;

public class Cannon : MonoBehaviour {
	public GameObject ballPrefab;
	public int bullet;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonUp(0) &&
		    bullet > 0) {
			GameObject ball = MonoBehaviour.Instantiate(ballPrefab) as GameObject;
			ball.name = "ball" + bullet--;
			Vector3 position = this.transform.position;
			ball.transform.position = position;
			ball.GetComponent<Rigidbody2D>().velocity = new Vector3(10, 0, 0);
		}
	}
}
