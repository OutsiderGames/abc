using UnityEngine;
using System.Collections;

public class Stage2 : AbcConfig {
	public Stage2 () {
		bullet = 15;
		ballBucketSize = 3;
		configs = new BallConfig[]{new BallConfig(2, -3, -15, -15, 4), new BallConfig(8, 3, 15, 15, 4)};
		hp = 40;
		speed = 5.0f;
		path = new Vector3[]{ new Vector3 (11, 5, 0), new Vector3 (11, -5, 0), new Vector3(11, 0, 0)};
	}
}

