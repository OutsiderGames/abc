using UnityEngine;
using System.Collections;

public class Stage11 : AbcConfig {
	public Stage11() {
		bullet = Random.Range (20, 40);
		ballBucketSize = Random.Range (2, 6);

		int distrubtBallCount = Random.Range (7, 16);
		BallConfig[] ballConfigs = new BallConfig[distrubtBallCount];
		for (int i = 0; i < distrubtBallCount; i++) {
			int xPos = Random.Range(-7, 12);
			int yPos = Random.Range(-9, 9);
			int xVel = Random.Range(-14, 15);
			int yVel = Random.Range(-14, 15);
			int color = Random.Range(1, 9);

			ballConfigs [i] = new BallConfig (xPos, yPos, xVel, yVel, color);
		}

		configs = ballConfigs;
		
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
