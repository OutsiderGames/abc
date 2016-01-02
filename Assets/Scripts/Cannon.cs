using UnityEngine;
using System.Collections;

public class Cannon : MonoBehaviour {
	public GameObject ballPrefab;
	public int count;

	private bool checking;

	// Use this for initialization
	void Start () {
		count = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonUp(0)) {
			GameObject ball = MonoBehaviour.Instantiate(ballPrefab) as GameObject;
			ball.name = "ball" + count++;
			Vector3 position = this.transform.position;
			ball.transform.position = position;
		}
	}
}
