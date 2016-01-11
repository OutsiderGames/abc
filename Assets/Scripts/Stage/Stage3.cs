using UnityEngine;
using System.Collections;

public class Stage3 : AbcConfig {
	public Stage3 () {
		bullet = 15;
		ballBucketSize = 3;
		configs = new BallConfig[]{};
		hp = 40;
		speed = 5.0f;
		path = new Vector3[]{ new Vector3 (11, 5, 0), new Vector3 (11, -5, 0), new Vector3(11, 0, 0)};
	}
}

