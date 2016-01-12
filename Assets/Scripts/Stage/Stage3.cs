using UnityEngine;
using System.Collections;

public class Stage3 : AbcConfig {
	public Stage3 () {
		bullet = 20;
		ballBucketSize = 1;
		configs = new BallConfig[]{};
		hp = 50;
		loopType = iTween.LoopType.loop;
		easeType = iTween.EaseType.linear;
		speed = 5.0f;
		path = new Vector3[]{ new Vector3 (16, 8, 0), new Vector3 (16, -8, 0), new Vector3(16, 0, 0)};
	}
}

