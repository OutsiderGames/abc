using UnityEngine;
using System.Collections;

public class Stage2 : AbcConfig {
	public Stage2 () {
		bullet = 20;
		ballBucketSize = 1;
		configs = new BallConfig[]{};
		hp = 50;
		loopType = iTween.LoopType.loop;
		easeType = iTween.EaseType.easeOutCirc;
		speed = 3.0f;
		path = new Vector3[]{new Vector3 (16, 5, 0), new Vector3 (18, 5, 0), new Vector3 (16, 5, 0), new Vector3 (18, 5, 0), new Vector3(16, 0, 0)};
	}
}

