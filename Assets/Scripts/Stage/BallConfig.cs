//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.18063
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using UnityEngine;

public class BallConfig {
	public Vector3 position;
	public Vector3 velocity;
	public int color;
	public int mass;

	public BallConfig(int xPos, int yPos, int xVel, int yVel, int color) {
		this.position = new Vector3(xPos, yPos, 0);
		this.velocity = new Vector3(xVel, yVel, 0);
		this.color = color;
		this.mass = 100;
	}

	public BallConfig(int xPos, int yPos, int xVel, int yVel, int color, int mass) {
		this.position = new Vector3(xPos, yPos, 0);
		this.velocity = new Vector3(xVel, yVel, 0);
		this.color = color;
		this.mass = mass;
	}
}


