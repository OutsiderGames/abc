using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class Ball : MonoBehaviour {
	private Rigidbody2D rb;
	private CircleCollider2D cc;
	public bool disturb;
	public int color;
	public List<GameObject> connected;
	
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		rb.drag = 0.0f;
		rb.angularVelocity = 0.0f;
		cc = GetComponents<CircleCollider2D>()[0];
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 position = this.transform.position;
		if (position.x > 25.0f ||
		    position.x < -25.0f ||
		    position.y > 25.0f ||
		    position.y < -25.0f) {
			Destroy(this.gameObject);
		}
		if (connected.Count >= 1) {
			foreach (GameObject ball in connected) {
				ball.SetActive (false);
				this.gameObject.SetActive (false);
			}
		}
	}

	void OnTriggerExit2D(Collider2D other) {
		if (other.gameObject.CompareTag ("Ball")) {
			if (connected.Contains (other.gameObject)) {
				connected.Remove (other.gameObject);
			}
		}
		if (other.name == "Entrance") {
			cc.enabled = true;
		}
	}
	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag ("Ball") &&
			other.gameObject.GetComponent<Ball>().color == color &&
			disturb == false &&
			other.gameObject.GetComponent<Ball>().disturb &&
			connected.Contains (other.gameObject) == false) {
			connected.Add (other.gameObject);
		}
		if (other.name == "Exit") {
			if (Math.Abs (rb.velocity.x) > 5.0f &&
			    disturb == false) {
				cc.enabled = false;
			} else if (Math.Abs (rb.velocity.x) > 10.0f &&
			           disturb == true) {
				cc.enabled = false;
			} else {
				disturb = true;
			}
		}
		if (other.CompareTag ("Wall") &&
			Math.Abs(rb.velocity.x) > 20.0f &&
			disturb == true) {
			gameObject.SetActive (false);
		}
	}
}
