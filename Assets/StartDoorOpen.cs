using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDoorOpen : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Animator anim = GetComponent<Animator> ();
		anim.Play ("DoorOpening");
	}

}
