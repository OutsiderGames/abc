using System;

public class Custom : CannonConfig {
	public static int cVelocity;
	public static int cMass;

	public Custom () {
		this.velocity = cVelocity;
		this.mass = cMass;
	}
}

