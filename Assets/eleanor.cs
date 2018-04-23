using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Gamekit2D;

public class eleanor : MonoBehaviour {
	public PlayerCharacter player;
	public Animator doorOuterLeft;
	public Animator doorOuterRight;
	public Animator doorInnerLeft;
	public Animator doorInnerRight;

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
			doorInnerLeft.Play ("DoorOpening");
			doorInnerRight.Play ("DoorClosing");

		} else if (time == 14) {
			// Start Eleanor Block
			doorOuterLeft.Play ("DoorOpening");
			// Close the inner doors.
			doorInnerLeft.Play ("DoorClosing");
			doorInnerRight.Play ("DoorClosing");

		} else if (time == 32) {
			// End Eleanor Block
			doorOuterLeft.Play ("DoorClosing");
			// Swap inner doors.
			doorInnerLeft.Play ("DoorClosing");
			doorInnerRight.Play ("DoorOpening");

		} else if (time == 45) {
			// Start Father Block
			doorOuterRight.Play ("DoorOpening");
			// Close the inner doors.
			doorInnerLeft.Play ("DoorClosing");
			doorInnerRight.Play ("DoorClosing");

		} else if (time == 63) {
			// End Father Block
			doorOuterRight.Play ("DoorClosing");

		} else if (time == 77) {
			// open inner doors
			doorInnerLeft.Play ("DoorOpening");
			doorInnerRight.Play ("DoorOpening");

		} else if (time == 90) {
			// Start Eleanor & Father Block
			doorOuterLeft.Play ("DoorOpening");
			doorOuterRight.Play ("DoorOpening");

			// close the inner doors
			doorInnerLeft.Play ("DoorClosing");
			doorInnerRight.Play ("DoorClosing");
		} else if (time == 108) {
			// End Eleanor & Father Block
			doorOuterLeft.Play ("DoorClosing");
			doorOuterRight.Play ("DoorClosing");

		} else if (time == 120) {
			// open all the doors, song is over.
			doorInnerLeft.Play ("DoorOpening");
			doorInnerRight.Play ("DoorOpening");
			doorOuterLeft.Play ("DoorOpening");
			doorOuterRight.Play ("DoorOpening");

		} else if (time == 126) {
			// Out of time, kill the player
			player.OnDie();
		}
//		Debug.Log (time);
	}

}
