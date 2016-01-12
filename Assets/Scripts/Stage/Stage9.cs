using UnityEngine;
using System.Collections;

public class Stage9 : AbcConfig {
	public Stage9() {
		bullet = 15;
		ballBucketSize = 3;
		configs = new BallConfig[]{new BallConfig(3, 0, 0, -10, 7), new BallConfig(6, 0, 0, 10, 7)};
		hp = 20;
		loopType = iTween.LoopType.loop;
		easeType = iTween.EaseType.linear;
		speed = 5.0f;
		path = new Vector3[]{ new Vector3 (16, 5, 0), new Vector3 (16, -5, 0), new Vector3(16, 0, 0) };
	}
}
