using UnityEngine;
using System.Collections;

public class Plane : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay2D(Collider2D other) {
		if (other.CompareTag("Ball") && 
		    other.attachedRigidbody) {
			other.attachedRigidbody.AddForce(new Vector2(0, 0));
		}
	}
}
