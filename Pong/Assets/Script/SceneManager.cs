using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour
{
	public void LoadLevel (string name)
	{
		//Debug.Log ("Loading level: " + name);
		Application.LoadLevel (name);
	}
	
	public void QuitRequested ()
	{
		//Debug.Log ("Quit Requested");
		Application.Quit ();
	}
}
