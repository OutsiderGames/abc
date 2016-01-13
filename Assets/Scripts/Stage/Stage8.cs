using UnityEngine;
using System.Collections;

public class Stage8 : AbcConfig {
	public Stage8() {
		bullet = 20;
		ballBucketSize = 5;
		configs = new BallConfig[]{
			new BallConfig(-2, 1, 5, -10, 5), new BallConfig(0, 1, 5, -10, 5), new BallConfig(2, 1, 5, -10, 5), new BallConfig(4, 1, 5, -10, 5), new BallConfig(6, 1, 5, -10, 5), new BallConfig(8, 1, 5, -10, 5), 
			new BallConfig(-2, -1, 5, 10, 5), new BallConfig(0, -1, 5, 10, 5), new BallConfig(2, -1, 5, 10, 5), new BallConfig(4, -1, 5, 10, 5), new BallConfig(6, -1, 5, 10, 5), new BallConfig(8, -1, 5, 10, 5)};
		hp = 50;
		loopType = iTween.LoopType.pingPong;
		easeType = iTween.EaseType.linear;
		speed = 30.0f;
		path = new Vector3[]{ new Vector3 (16, 5, 0), new Vector3 (18, -5, 0), new Vector3(16, -5, 0), new Vector3(18, 5, 0) };
	}
}
