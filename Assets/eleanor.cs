using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eleanor : MonoBehaviour {
	public GameObject eleanor1;
	public GameObject eleanor2;

	AudioSource songAudio;


	// Use this for initialization
	void Start () {
		songAudio = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		int time = (int)songAudio.time;
		Debug.Log (time);

		if (time == 14 && eleanor1.activeSelf) {
			eleanor1.SetActive (false);
			eleanor2.SetActive (true);
		}
	}

}
