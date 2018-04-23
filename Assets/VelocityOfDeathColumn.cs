using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityOfDeathColumn : MonoBehaviour {

	public float deathVelocity;
	public float deathAngularMomentum;
	public float headStartTime;

	// Use this for initialization
	IEnumerator Start () {
		yield return new WaitForSeconds (headStartTime);
		Rigidbody2D rigidBodyOfDoom = transform.GetComponent<Rigidbody2D> ();
		rigidBodyOfDoom.velocity = new Vector2 (deathVelocity, 0f);
		rigidBodyOfDoom.angularVelocity = deathAngularMomentum;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
