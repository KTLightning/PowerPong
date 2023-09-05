using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject Prefab;
	public int numberOfPrefabs;
	public int Xmin, Xmax, Ymin, Ymax;
	public float spawnTime = 3f;

	void Start () 
	{
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}

	void Spawn ()
	{
		//for(int i = 0; i < numberOfPrefabs;i++)
		{
			Instantiate(Prefab,GeneratedPosition (),Quaternion.identity);
		}
	}
	Vector2 GeneratedPosition () 
	{
		int x, y;
		x = UnityEngine.Random.Range (Xmin, Xmax);
		y = UnityEngine.Random.Range (Ymin, Ymax);
		return new Vector2 (x, y);
	}
}
