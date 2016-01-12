using UnityEngine;
using System.Collections;

public class Stage1 : AbcConfig {
	public Stage1() {
		bullet = 20;
		ballBucketSize = 1;
		configs = new BallConfig[]{};
		hp = 50;
		loopType = iTween.LoopType.loop;
		easeType = iTween.EaseType.linear;
		speed = 1.0f;
		path = new Vector3[]{ new Vector3 (16, 1, 0), new Vector3 (16, -1, 0), new Vector3(16, 0, 0) };
	}
}
