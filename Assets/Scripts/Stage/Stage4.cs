using UnityEngine;
using System.Collections;

public class Stage4 : AbcConfig {
	public Stage4() {
		bullet = 20;
		ballBucketSize = 1;
		configs = new BallConfig[]{new BallConfig(0, 0, 0, -8, 1), new BallConfig(5, 4, 0, -8, 1), new BallConfig(10, 8, 0, -8, 1)};
		hp = 50;
		loopType = iTween.LoopType.pingPong;
		easeType = iTween.EaseType.linear;
		speed = 20.0f;
		path = new Vector3[]{ new Vector3 (16, 2, 0), new Vector3 (16, -2, 0)};
	}
}
