using UnityEngine;
using System.Collections;

public class Stage4 : AbcConfig {
	public Stage4() {
		bullet = 15;
		ballBucketSize = 1;
		configs = new BallConfig[]{new BallConfig(-8, -4, 0, -15, 1), new BallConfig(-3, 0, 0, -15, 1), new BallConfig(2, 4, 0, -15, 1), new BallConfig(7, 8, 0, -15, 1)};
		hp = 50;
		loopType = iTween.LoopType.pingPong;
		easeType = iTween.EaseType.linear;
		speed = 20.0f;
		path = new Vector3[]{ new Vector3 (16, 2, 0), new Vector3 (16, -2, 0)};
	}
}
