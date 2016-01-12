using UnityEngine;
using System.Collections;

public class Stage7 : AbcConfig {
	public Stage7() {
		bullet = 30;
		ballBucketSize = 3;
		configs = new BallConfig[]{new BallConfig(-4, -9, -15, 15, 4, 500), new BallConfig(-4, -7, -15, 15, 4, 500), new BallConfig(-4, -5, -15, 15, 4, 500), new BallConfig(-4, -3, -15, 15, 4, 500), new BallConfig(-4, -1, -15, 15, 4, 500), new BallConfig(-4, 1, -15, -15, 4, 500), new BallConfig(-4, 3, -15, -15, 4, 500), new BallConfig(-4, 5, -15, -15, 4, 500), new BallConfig(-4, 7, -15, -15, 4, 500), new BallConfig(-4, 9, -15, -15, 4, 500)};
		hp = 50;
		loopType = iTween.LoopType.pingPong;
		easeType = iTween.EaseType.linear;
		speed = 15.0f;
		path = new Vector3[]{ new Vector3 (16, 5, 0), new Vector3 (16, -5, 0)};
	}
}
