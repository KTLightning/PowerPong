using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{
	// Hastighet som kan ändras i Inspector
	public bool startCount = false;
	public float speed = 2.0f;
	float speedLength = 5f;
	public float SpeedLength = 5f;
	public float speedAmount;
	public bool isLeft = false;
	public int timesHit;
	void Start ()
	{
		speedLength = SpeedLength;
		reset ();
	}

	public void addSpeed(float speedAmount)
	{
	//	speed += speedAmount;
		if (GetComponent<Rigidbody2D> ().velocity.x < 0) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x - speedAmount, GetComponent<Rigidbody2D> ().velocity.y);
		} else {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x + speedAmount, GetComponent<Rigidbody2D> ().velocity.y);
		}

	}
	public void removeSpeed(float speedAmount)
	{
		//speed += speedAmount;
		if (GetComponent<Rigidbody2D> ().velocity.x < 0) {
			speedAmount = -speedAmount;
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x - speedAmount, GetComponent<Rigidbody2D> ().velocity.y);
		} else {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x - speedAmount, GetComponent<Rigidbody2D> ().velocity.y);
		}
	}
	float hitFactor(Vector2 ballPos, Vector2 racketPos,
	                float racketHeight)
	{
		return (ballPos.y - racketPos.y) / racketHeight;
	}

	void stop()
	{
		GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
	}

	 void reset()
	{
		transform.localPosition = new Vector3(0,0,0);
		GetComponent<Rigidbody2D>().velocity = Vector2.one.normalized * speed;
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.name == "WallLeft")
		{
			GameManager.Score("WallLeft");

		} else if(col.gameObject.name == "WallRight")
		{
			GameManager.Score("WallRight");
		}
	}
	void Update() {

		if (startCount) {
			speedLength -= 1f * Time.deltaTime;
			if (speedLength <= 0f) {
				startCount = false;
				speedLength = SpeedLength;
				removeSpeed (speedAmount * timesHit);
				timesHit = 0;
			}
		}
	}
}
