using UnityEngine;
using System.Collections;

public class Stage6 : AbcConfig {
	public Stage6() {
		bullet = 15;
		ballBucketSize = 3;
		configs = new BallConfig[]{};
		hp = 40;
		loopType = iTween.LoopType.loop;
		easeType = iTween.EaseType.linear;
		speed = 5.0f;
		path = new Vector3[]{ new Vector3 (16, 5, 0), new Vector3 (16, -5, 0), new Vector3(16, 0, 0)};
	}
}
