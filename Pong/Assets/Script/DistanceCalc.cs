using UnityEngine;
using System.Collections;

public class DistanceCalc : MonoBehaviour {
	GameObject ball;
	float calc = 0f;
	void Start() {
		ball = GameObject.Find ("Ball");
	}
	void Update () {
		calc = ball.transform.position.x - transform.position.x;
		Ball ballScript = ball.GetComponent<Ball> ();
		if (calc >= 1f) {
			ballScript.isLeft = false;
		} else if (calc <= -1f) {
			ballScript.isLeft = true;
		}
	}
}
