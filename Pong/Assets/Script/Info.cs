using UnityEngine;
using System.Collections;

public class Info : MonoBehaviour {

	void Start () {
		Time.timeScale = 0.00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001f;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown) {
			try{
				GameObject panel = GameObject.Find ("Panel");
				panel.SetActive (false);
				Time.timeScale = 1f;
			}
			catch{
			}

		}
	
	}
}
