using UnityEngine;
using System.Collections;

public class Stage5 : AbcConfig {
	public Stage5() {
		bullet = 20;
		ballBucketSize = 1;
		configs = new BallConfig[]{new BallConfig(-7, -9, -15, -15, 3), new BallConfig(2, 0, 15, -15, 3)};
		hp = 50;
		loopType = iTween.LoopType.pingPong;
		easeType = iTween.EaseType.linear;
		speed = 20.0f;
		path = new Vector3[]{ new Vector3 (16, 3, 0), new Vector3 (16, -3, 0)};
	}
}
