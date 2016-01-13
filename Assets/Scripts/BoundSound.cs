using UnityEngine;
using System.Collections;

public class BoundSound : MonoBehaviour {
	[SerializeField]
	private AudioClip[] sounds;

	private AudioSource audioSource;
	private const float soundVolLowRange = .01f;
	private const float soundVolHighRange = .02f;

	// Use this for initialization
	void Start () {
		audioSource = gameObject.AddComponent<AudioSource> ();
		audioSource.playOnAwake = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag ("Ball") ) {
			PlayThrowSound ();
		}
	}

	void PlayThrowSound() {
		int idx = Random.Range (0, sounds.Length);
		AudioClip playSound = sounds [idx];

		float vol = UnityEngine.Random.Range (soundVolLowRange, soundVolHighRange);
		if (audioSource != null && playSound != null) {
			audioSource.PlayOneShot (playSound, vol);
		}
	}
}
