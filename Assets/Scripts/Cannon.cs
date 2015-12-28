using UnityEngine;
using System.Collections;

public class Cannon : MonoBehaviour {
	public GameObject ballPrefab;
	public int count;

	// Use this for initialization
	void Start () {
		count = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0)) {
			GameObject ball = MonoBehaviour.Instantiate(ballPrefab) as GameObject;
			ball.name = "ball" + count++;
			Vector3 position = this.transform.position;
			position.x += count * 0.1F;
			ball.transform.position = position;
		}
	}
}
