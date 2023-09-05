using UnityEngine;
using System.Collections;

public class SpeedPowerUp : MonoBehaviour 
{
	public float speedAmount;
	private float compteur = 30f;
	bool startCount = false;
	// Use this for initialization
	void Update() {
		


		compteur -= 1 * Time.deltaTime;
	}
	void FixedUpdate () {
		if (compteur <= 0)
		{
			Destroy(this.gameObject);

		}

	}
	
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.name == "Ball") 
		{
			startCount = true;
			GameObject theBall = other.gameObject;
			Ball rb = theBall.GetComponent<Ball> ();
			rb.addSpeed (speedAmount);
			rb.startCount = true;
			rb.timesHit += 1;
			Destroy (this.gameObject);

		}
	}
}
