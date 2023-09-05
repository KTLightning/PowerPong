using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
	public static int playerScore1 = 0;
	public static int playerScore2 = 0;

	public GUISkin layout;

	GameObject ball;

	void Start()
	{
		ball = GameObject.Find("Ball");
	}

	public static void Score (string wallID)
	{
		if (wallID == "WallRight")
		{
			playerScore1++;
		}else if(wallID == "WallLeft")
		{
			playerScore2++;
		}
	}

	void OnGUI()
	{
		GUI.skin = layout;
		GUI.Label (new Rect (Screen.width / 2 - 150 - 12, 20, 100,100), "" + playerScore1);
		GUI.Label (new Rect (Screen.width / 2 + 150 + 12, 20, 100,100), "" + playerScore2);

		if (GUI.Button (new Rect (Screen.width/2 - 60, 35, 120, 53), "RESET"))
		{
			playerScore1 = 0;
			playerScore2 = 0;
			ball.SendMessage("reset", 0.5f, SendMessageOptions.RequireReceiver);
		}

		if (playerScore2 == 10)
		{
			GUI.Label (new Rect (Screen.width / 2 - 150, 200, 2000, 1000), "PLAYER ONE WINS");
			ball.SendMessage("stop",null,SendMessageOptions.RequireReceiver);
		}else if (playerScore1 == 10)
		{
			GUI.Label(new Rect (Screen.width /2 -150, 200, 2000, 1000), "PLAYER TWO WINS");
			ball.SendMessage("stop",null,SendMessageOptions.RequireReceiver);
		}
	}
}
