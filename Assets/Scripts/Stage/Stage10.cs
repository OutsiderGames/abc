using UnityEngine;
using System.Collections;

public class Stage10 : AbcConfig {
	public Stage10() {
		bullet = 40;
		ballBucketSize = 3;
		configs = new BallConfig[]{
			new BallConfig(-7, 9, 3, -14, 1), new BallConfig(-5, 9, 3, -14, 2), new BallConfig(-3, 9, 3, -14, 3), new BallConfig(-1, 9, 3, -14, 4), 
			new BallConfig(1, 9, 3, -14, 5), new BallConfig(3, 9, 3, -14, 6), new BallConfig(5, 9, 3, -14, 7), new BallConfig(7, 9, 3, -14, 8)};
		hp = 50;
		loopType = iTween.LoopType.loop;
		easeType = iTween.EaseType.linear;
		speed = 15.0f;
		path = new Vector3[]{ 
			new Vector3 (16, 5, 0), new Vector3 (17, -4, 0), new Vector3(18, 3, 0), new Vector3(17, -2, 0), new Vector3(16, 1, 0), new Vector3(17, 0, 0), 
			new Vector3 (18, -1, 0), new Vector3 (17, 2, 0), new Vector3 (16, -3, 0), new Vector3 (17, 4, 0), new Vector3 (18, -5, 0), 
			new Vector3 (17, 4, 0), new Vector3 (16, -3, 0), new Vector3 (17, 2, 0), new Vector3 (18, -1, 0), new Vector3 (17, 0, 0), 
			new Vector3 (16, 1, 0), new Vector3 (17, -2, 0), new Vector3 (18, 3, 0), new Vector3 (17, -4, 0), new Vector3 (16, 5, 0)
		};
	}
}
