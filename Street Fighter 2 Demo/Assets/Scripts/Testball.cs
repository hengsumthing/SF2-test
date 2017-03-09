using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testball : MonoBehaviour {
	public GameObject laser;
	public Transform laserSpawn;

	private float nextFire = 0.5f ;
		private float myTime = 0.0f;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
		myTime += Time.deltaTime;
		if (Input.GetButton ("fire") && myTime > nextFire) {
			Instantiate (laser, laserSpawn.position, laserSpawn.rotation);
			myTime = 0.0f;
		}

	if(Input.GetButton("Fire1"))
	{
			Instantiate (laser, laserSpawn.position, laserSpawn.rotation);
	}
	}
}
