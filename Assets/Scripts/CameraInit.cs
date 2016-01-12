using UnityEngine;
using System.Collections;

public class CameraInit : MonoBehaviour {
	
	const float DefaultHeight = 750f;
	const float DefaultCameraSize = 30f;

	// Use this for initialization
	void Start () {
		float cameraSize = (Screen.height / DefaultHeight) * DefaultCameraSize;
		Camera.main.orthographicSize = cameraSize;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
