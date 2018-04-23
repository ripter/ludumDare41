using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class tntSequencer : MonoBehaviour
{

	public AudioSource levelSong;
	private Dictionary<string, bool> runnables = new Dictionary<string, bool>();

	public GameObject fireballObject;
	public GameObject ellen;


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
	void FixedUpdate ()
	{
		if ((bool)ellen) {
			float offsetFromCurrent = Random.Range (-3, 13) + ellen.transform.position.x;
			if ((int)(levelSong.time * 100) % 48 == 0) {
//				print ("FIREBALL!!!!");
				GameObject fireball;
				fireball = Instantiate (fireballObject, new Vector3 (offsetFromCurrent, 21.9f, 0.0f), Quaternion.identity);
				fireball.SetActive (true);
				Destroy (fireball, 10);
			}
		}
	}
}