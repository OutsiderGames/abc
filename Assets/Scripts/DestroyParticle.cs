using UnityEngine;
using System.Collections;

public class DestroyParticle : MonoBehaviour {

	public class DestroyParticles : MonoBehaviour
	{
		private IEnumerator Start()
		{
			yield return new WaitForSeconds(2f);
			Destroy(gameObject); 
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
