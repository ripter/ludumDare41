﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeWithMusic : MonoBehaviour {
	public AudioSource levelSong;
	public bool two;

	// Use this for initialization
	void Start () {
		Debug.Log("I am alive");
	}
	
	// Update is called once per frame
	void Update () {
		if (Math.Floor(levelSong.time) == 5) {
			Debug.Log ("Turn on the light");
			Animator me = this.GetComponent<Animator> ();
			me.SetTrigger ("SwitchTriggered");
		}

		GameObject fooBar;
		Transform myTransform = GetComponent<Transform> ();
	}
}
