using UnityEngine;
using System.Collections;

public class Stage9 : AbcConfig {
	public Stage9() {
		bullet = 30;
		ballBucketSize = 3;
		configs = new BallConfig[]{
			new BallConfig(-7, 9, 1, -12, 6), new BallConfig(-6, 8, 1, -12, 6), new BallConfig(-5, 7, 1, -12, 6), new BallConfig(-4, 6, 1, -12, 6), 
			new BallConfig(-3, 5, 1, -12, 6), new BallConfig(-2, 4, 1, -12, 6), new BallConfig(-1, 3, 1, -12, 6), new BallConfig(0, 2, 1, -12, 6)};
		hp = 50;
		loopType = iTween.LoopType.loop;
		easeType = iTween.EaseType.linear;
		speed = 10.0f;
		path = new Vector3[]{ new Vector3 (16, 0, 0), new Vector3 (17, 3, 0), new Vector3(18, 0, 0), new Vector3 (17, -3, 0), new Vector3 (16, 0, 0)};
	}
}
