using UnityEngine;
using System.Collections;

public class Stage3 : AbcConfig {
	public Stage3 () {
		bullet = 20;
		ballBucketSize = 1;
		configs = new BallConfig[]{new BallConfig(7, 0, 5, -2, 5)};
		hp = 50;
		loopType = iTween.LoopType.loop;
		easeType = iTween.EaseType.linear;
		speed = 1.0f;
		path = new Vector3[]{ new Vector3 (16, 8, 0), new Vector3 (18, 8, 0), new Vector3(16, 8, 0)};
	}
}

