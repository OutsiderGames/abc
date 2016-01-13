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
	public GameObject particle;
	public GameObject particleInstance = null;
	
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		rb.drag = 0.0f;
		rb.angularVelocity = 0.0f;
		cc = GetComponents<CircleCollider2D>()[0];
		particle = Resources.Load ("ExplosionMobile", typeof(GameObject)) as GameObject;
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
				// Destory two balls
				ball.SetActive (false);
				this.gameObject.SetActive (false);
				particle.transform.position = transform.position;
				particleInstance = Instantiate (particle) as GameObject;
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
			if (cc == null) {
				cc = GetComponents<CircleCollider2D>()[0];
			}
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
			} else {
				disturb = true;
			}
		}
		if (other.CompareTag ("Wall") &&
			Math.Abs(rb.velocity.x) > 50.0f &&
			disturb == true) {
			// Destory ball with wall
			gameObject.SetActive (false);
		}
	}
}
