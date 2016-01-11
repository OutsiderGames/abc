using UnityEngine;
using System;
using System.Collections;

public class Cannon : MonoBehaviour {
	[SerializeField]
	private Camera camera;

	private AbcConfig config;
	private int bullet;
	private int ballBucketSize;
	private float speed;
	private float moveThresholdX;
	private float scaleY;
	private int velocity;
	private int mass;

	// Use this for initialization
	void Start () {
		AbcConfig config = (AbcConfig)Activator.CreateInstance(Type.GetType (Menu.getStage ()));
		bullet = config.bullet;
		ballBucketSize = config.ballBucketSize;
		speed = 0.3f;
		moveThresholdX = Screen.width * 0.3f;
		scaleY = Screen.height / 20.0f;
		velocity = 10;
		mass = 100;
	}
	
	// Update is called once per frame
	void Update () {
		if (isFire() &&
			bullet > 0) {
			ThrowBall ();
		}
		Vector2? movePosition = getMovePosition ();
		if (movePosition.HasValue) {
			moveTo (movePosition.Value);
		}
	}

	Vector2? getMovePosition() {
		if (Input.GetMouseButton (0) &&
			isMovePosition(Input.mousePosition)) {
			return Input.mousePosition;
		}
		if (Input.touches.Length > 0) {
			foreach(Touch touch in Input.touches) {
				if (touch.phase == TouchPhase.Began &&
					isMovePosition(touch.position)) {
					return touch.position;
				}
			}
		}
		return null;
	}

	bool isMovePosition(Vector2 position) {
		return position.x < moveThresholdX;
	}
	bool isFirePosition(Vector2 position) {
		return isMovePosition (position) == false;
	}

	bool isFire() {
		if (Input.GetMouseButtonUp (0) &&
			isFirePosition(Input.mousePosition)) {
			return true;
		}
		if (Input.touches.Length > 0) {
			foreach(Touch touch in Input.touches) {
				if (touch.phase == TouchPhase.Ended &&
					isFirePosition(touch.position)) {
					return true;
				}
			}
		}
		return false;
	}

	void moveTo(Vector2 position) {
		
		float start = this.transform.position.y;
		float end = position.y / scaleY - 10;
		float y = this.transform.position.y;
		Debug.Log (camera.ScreenToWorldPoint(position));
		Debug.Log (this.transform.position);
		if (start > end) {
			y = start - speed > end ? start - speed : end;
		}
		if (start < end) {
			y = start + speed < end ? start + speed : end;
		}
		this.transform.position = new Vector2(this.transform.position.x, y);
	}

	void ThrowBall() {
		int ballNumber = (int) UnityEngine.Random.Range(1, ballBucketSize + 1);
		GameObject ball = Instantiate(Resources.Load("Balls/ball_" + ballNumber ,typeof(GameObject))) as GameObject;
		ball.name = "ball" + bullet--;
		ball.GetComponent<Ball> ().color = ballNumber;
		ball.GetComponent<Ball> ().disturb = false;
		Vector3 position = this.transform.position;
		ball.transform.position = new Vector3(position.x + 1.5f, position.y, position.z);
		ball.GetComponent<Rigidbody2D>().velocity = new Vector3(velocity, 0, 0);
		ball.GetComponent<Rigidbody2D> ().mass = mass;
	}
}
