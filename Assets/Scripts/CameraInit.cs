using UnityEngine;
using System.Collections;

public class CameraInit : MonoBehaviour {

	const float DefaultWidth = 640f;
	const float DefaultCameraSize = 12f;

	// Use this for initialization
	void Start () {
		float cameraSize = (Screen.width / DefaultWidth) * DefaultCameraSize;
		Camera.main.orthographicSize = cameraSize;
	}
	
	// Update is called once per frame
	void Update () {
	}
}
