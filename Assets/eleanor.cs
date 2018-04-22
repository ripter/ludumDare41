using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eleanor : MonoBehaviour {
	public Animator door1;
	public Animator door2;
	public Animator door3;
	public Animator door4;

	AudioSource songAudio;
	private int lastTime;

	// Use this for initialization
	void Start () {
		songAudio = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		int time = (int)songAudio.time;

		// Only trigger once per rounded second.
		if (lastTime == time) {
			return;
		}
		lastTime = time;

		// Control animations based on song time.
		if (time == 1) {
			door2.Play ("DoorOpening");
		} else if (time == 14) {
			door1.Play ("DoorOpening");
			door2.Play ("DoorClosing");
		} else if (time == 32) {
			door1.Play ("DoorClosing");
		} else if (time == 45) {

		} else if (time == 63) {

		} else if (time == 77) {

		} else if (time == 90) {

		} else if (time == 108) {

		} else if (time == 120) {

		}
		Debug.Log (time);
	}

}
