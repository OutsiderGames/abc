using UnityEngine;
using System.Collections;

public class Scene1 : AbcConfig {
	public Scene1() {
		bullet = 15;
		ballBucketSize = 3;
		configs = new BallConfig[]{new BallConfig(3, 0, 0, -10), new BallConfig(6, 0, 0, 10)};
	}
}
