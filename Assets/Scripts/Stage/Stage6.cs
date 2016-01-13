using UnityEngine;
using System.Collections;

public class Stage6 : AbcConfig {
	public Stage6() {
		bullet = 20;
		ballBucketSize = 4;
		configs = new BallConfig[]{new BallConfig(-7, -9, -15, -15, 1, 500), new BallConfig(11, -9, 15, -15, 2, 500), new BallConfig(11, 9, 15, 15, 3, 500), new BallConfig(-7, 9, -15, 15, 4, 500)};
		hp = 50;
		loopType = iTween.LoopType.pingPong;
		easeType = iTween.EaseType.linear;
		speed = 20.0f;
		path = new Vector3[]{ new Vector3 (16, 4, 0), new Vector3 (16, -4, 0)};
	}
}
