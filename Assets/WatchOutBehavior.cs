using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatchOutBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		if (this.transform.position.y < 50) {
			this.transform.Translate(new Vector3(0f, 0.2f, 0f));
		}
	}
}
