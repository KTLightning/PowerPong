using UnityEngine;
using System.Collections;

public class FindBall : MonoBehaviour 
{

	public Transform ball;
	float Addspeed;
	public float Speed;


	// Use this for initialization
	void Update () 
	{
		Addspeed = Time.deltaTime * Speed;

		if (ball.position.y >= transform.position.y + 3)
		{
			transform.Translate(Vector3.up * Addspeed);
		}
	
		else if (ball.position.y <= transform.position.y - 3)
		{
			transform.Translate(Vector3.down * Addspeed);
		}
	
	}
	
	void OnCollisonEnter(Collision collision)
	{
		if (collision.gameObject.name == "ball") 
		{
			collision.rigidbody.AddForce (10,0,0);
		}
	}
	
}