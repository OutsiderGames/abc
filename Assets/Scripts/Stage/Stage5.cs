using UnityEngine;
using System.Collections;

public class Stage5 : AbcConfig {
	public Stage5() {
		bullet = 15;
		ballBucketSize = 3;
		configs = new BallConfig[]{new BallConfig(2, -3, -15, -15, 4), new BallConfig(8, 3, 15, 15, 4)};
		hp = 40;
		loopType = iTween.LoopType.loop;
		easeType = iTween.EaseType.linear;
		speed = 5.0f;
		path = new Vector3[]{ new Vector3 (16, 5, 0), new Vector3 (16, -5, 0), new Vector3(16, 0, 0)};
	}
}
