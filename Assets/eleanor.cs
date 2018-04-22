using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eleanor : MonoBehaviour {
	public Animator door1;
	public Animator door2;
	public Animator door3;
	public Animator door4;

	AudioSource songAudio;


	// Use this for initialization
	void Start () {
		songAudio = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		int time = (int)songAudio.time;
		Debug.Log (time);

		if (time == 0) {
			door2.Play ("DoorOpening");
		}
		else if (time == 14) {
			door1.Play("DoorOpening");
			door2.Play ("DoorClosing");
		}
//		if (time == 14 && eleanor1.activeSelf) {
//			eleanor1.SetActive (false);
//			eleanor2.SetActive (true);
//		}
	}

}
