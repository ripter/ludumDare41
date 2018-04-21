using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeTriggerSwitch : MonoBehaviour {
	public AudioSource levelSong;
	private bool didPlay = false;

	// Use this for initialization
	void Start () {
//		Debug.Log("I am alive");
	}
	
	// Update is called once per frame
	void Update () {
		int songTime = (int)levelSong.time;

		// We only want to trigger the animation once
		// But because we round the time, our if might be called more than once.
		if (didPlay) {
			return;
		}

		if (songTime == 5) {
			// Get the animator on our self and call triggered animation
			Animator anim = GetComponent<Animator> ();
			anim.SetTrigger ("SwitchTriggered");
			// don't trigger the animation again
			didPlay = true;
		}
	}
}
