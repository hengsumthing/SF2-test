using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour {
	public float speed;
	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		rb = GetComponent<Rigidbody2D> ();
        if (character.facingRight == true)
        {
            rb.velocity = transform.right * speed;
        }
        if (character.facingRight == false)
        {
            rb.velocity =- transform.right * speed;
        }


    }
}
