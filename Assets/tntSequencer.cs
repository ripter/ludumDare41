using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class tntSequencer : MonoBehaviour
{

	public AudioSource levelSong;
	private Dictionary<string, bool> runnables = new Dictionary<string, bool>();

	public GameObject fireball1;
	public GameObject fireball2;
	public GameObject fireball3;
	public GameObject fireball4;
	public GameObject fireball5;


	// Use this for initialization
	void Start ()
	{
		
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
		RunAt (5, fireball1);
		RunAt (6, fireball2);
		RunAt (10, fireball3);
		RunAt (14, fireball4);
		RunAt (17, fireball5);
	}
}