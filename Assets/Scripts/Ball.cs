using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	private Rigidbody2D rb;
	private CircleCollider2D cc;
	public bool disturb;
	public int color;
	
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
		if (position.x > 15.0f ||
		    position.x < -15.0f ||
		    position.y > 15.0f ||
		    position.y < -15.0f) {
			Destroy(this.gameObject);
		}
	}

	void OnTriggerExit2D(Collider2D other) {
		if (other.name == "Entrance") {
			cc.enabled = true;
		}
	}
	void OnTriggerEnter2D(Collider2D other) {
		if (other.name == "Exit") {
			if (rb.velocity.x > 5.0f &&
				disturb == false) {
				cc.enabled = false;
			} else {
				disturb = true;
			}
		}
	}
}
