using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Collections;

public class Cannon : MonoBehaviour {
	[SerializeField]
	private Camera camera;
	[SerializeField]
	private AudioClip throwSound;

	private AbcConfig config;
	private int bullet;
	private int maxBullet;
	private int ballBucketSize;
	private float speed;
	private float moveThresholdX;
	private float scaleY;
	private int velocity;
	private int mass;

	private Animator throwAnimator;
	private SpriteRenderer spriteRenderer;

	private AudioSource audioSource;
	private float throwSoundVolLowRange = .6f;
	private float throwSoundVolHighRange = 1f;

	private volatile bool fireThrowBall = false;

	private bool endFlag;
	private int endTimer;

	private float energy = 1f;
	private GameObject fillBarGameObject;

	// Use this for initialization
	void Start () {
		AbcConfig config = (AbcConfig)Activator.CreateInstance (Type.GetType (StageMenu.getStage ()));
		maxBullet = bullet = config.bullet;
		ballBucketSize = config.ballBucketSize;
		speed = 0.3f;
		moveThresholdX = Screen.width * 0.3f;
		scaleY = Screen.height / 20.0f;

		throwAnimator = GetComponent<Animator> ();
		spriteRenderer = GetComponent<SpriteRenderer> ();
		audioSource = GetComponent<AudioSource> ();

		CannonConfig cannon = (CannonConfig)Activator.CreateInstance (Type.GetType (CannonMenu.getCannon ()));
		velocity = cannon.velocity;
		mass = cannon.mass;
		endFlag = false;
		endTimer = 0;

		// create energy bar
		GameObject energyBarGameObject = Instantiate (Resources.Load ("EnergyBar", typeof(GameObject))) as GameObject;
		energyBarGameObject.transform.parent = gameObject.transform;
		energyBarGameObject.transform.position = new Vector3 (transform.position.x - 2f , transform.position.y - 1.5f, 0);
		energyBarGameObject.name = "CannonEnergyBar";
		fillBarGameObject = GameObject.Find ("CannonEnergyBar/EnergyFillBar");
	}

	// Update is called once per frame
	void FixedUpdate () {
		// start play shot animation
		if (isFire () && bullet > 0 ) {
			throwAnimator.SetBool ("shoting", true);
			fireThrowBall = true;
		} else if (isFire () ) {
			throwAnimator.SetBool ("shot_fail", true);
		}

		// shot_4 is exactly shot image
		if (fireThrowBall && spriteRenderer.sprite.name == "shot_4") {
			ThrowBall ();
			PlayThrowSound ();
			SetEnergyBar ();
			fireThrowBall = false;
		}

		checkFail ();
			
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

		ball.transform.position = new Vector3(position.x + 1.6f, position.y + 0.4f, 0);
		ball.GetComponent<Rigidbody2D>().velocity = new Vector3(velocity, 0, 0);
		ball.GetComponent<Rigidbody2D> ().mass = mass;

		energy = (float) bullet / (float) maxBullet;
	}

	void PlayThrowSound() {
		float vol = UnityEngine.Random.Range (throwSoundVolLowRange, throwSoundVolHighRange);
		audioSource.PlayOneShot (throwSound, vol);
	}

	void checkFail() {
		if (bullet == 0 && endFlag == false) {
			endTimer = 300;
			endFlag = true;
		}
		if (endFlag) {
			endTimer--;
		}
		if (endTimer < 0) {
			SceneManager.LoadScene ("fail");
		}
	}

	void SetEnergyBar() {
		fillBarGameObject.transform.localScale = new Vector3(energy, 1, 1);
	}
}
