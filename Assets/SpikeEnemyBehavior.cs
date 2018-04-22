using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeEnemyBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate(new Vector3(0.05f, 0f, 0f));
	}
}
