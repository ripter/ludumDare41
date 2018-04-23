using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class tntSequencer : MonoBehaviour
{

	public AudioSource levelSong;
	private Dictionary<string, bool> runnables = new Dictionary<string, bool>();

	public GameObject fireball0;
	public GameObject fireball1;
	public GameObject fireball2;
	public GameObject fireball3;
	public GameObject fireball4;
	public GameObject fireball5;

	public Vector3 originalPosition;


	// Use this for initialization
	void Start ()
	{
		print (fireball0.transform.position);
		originalPosition = fireball0.transform.position;
	}

	void RunAt (int targetTime, GameObject targetObject)
	{
		int songTime = (int)levelSong.time;
		string key = targetObject.name;
		if (songTime == targetTime && !runnables.ContainsKey(key)) {
			runnables.Add(key, true);
			targetObject.SetActive (true);
			Debug.Log(songTime);
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		if ((int)(levelSong.time * 1000) % 476 == 0)
			fireball0.transform.position = new Vector3(0.0f, 21.9f, 0.0f);
			fireball0.SetActive (!fireball1.activeSelf);
		RunAt (8, fireball1);
		RunAt (10, fireball2);
		RunAt (12, fireball3);
		RunAt (14, fireball4);
		RunAt (16, fireball5);
	}
}