using UnityEngine;
using System.Collections;

public class Cannon : MonoBehaviour {
	private AbcConfig config;
	private int bullet;
	private int ballBucketSize;
	private float moveThresholdX;
	private float scaleY;

	// Use this for initialization
	void Start () {
		if (Menu.scene == null) {
			Menu.scene = "Scene1";
		}
		AbcConfig config = GameObject.Find (Menu.scene).GetComponent<AbcConfig>();
		bullet = config.bullet;
		ballBucketSize = config.ballBucketSize;
		moveThresholdX = Screen.width * 0.3f;
		scaleY = Screen.height / 20.0f;
		Debug.Log (Screen.height);
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
		Debug.Log (y);
		Debug.Log (position);
		if (start > end) {
			y = start - 1.0f > end ? start - 1.0f : end;
		}
		if (start < end) {
			y = start + 1.0f < end ? start + 1.0f : end;
		}
		this.transform.position = new Vector2(this.transform.position.x, y);
	}

	void ThrowBall() {
		int ballNumber = (int) Random.Range(1, ballBucketSize + 1);
		GameObject ball = Instantiate(Resources.Load("Balls/ball_" + ballNumber ,typeof(GameObject))) as GameObject;
		ball.name = "ball" + bullet--;
		Vector3 position = this.transform.position;
		ball.transform.position = position;
		ball.GetComponent<Rigidbody2D>().velocity = new Vector3(10, 0, 0);
	}
}
