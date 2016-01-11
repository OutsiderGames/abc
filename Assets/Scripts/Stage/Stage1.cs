using UnityEngine;
using System.Collections;

public class Stage1 : AbcConfig {
	public Stage1() {
		bullet = 15;
		ballBucketSize = 3;
		configs = new BallConfig[]{new BallConfig(3, 0, 0, -10, 7), new BallConfig(6, 0, 0, 10, 7)};
		hp = 20;
		speed = 5.0f;
		path = new Vector3[]{ new Vector3 (11, 5, 0), new Vector3 (11, -5, 0), new Vector3(11, 0, 0) };
	}
}
