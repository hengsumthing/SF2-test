using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour {
	public static float Speed = 10f;
	public static float movex = 10f;
	public static float movey = 10f;
	public static bool facingRight= true;
	public static Animator anim;




	// Use this for initialization
	void Start () {
		anim = GetComponent < Animator> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		movex = Input.GetAxis ("Horizontal");
		movey = Input.GetAxis ("Vertical");
		//trigger walk ani
		anim.SetFloat("Speed", Mathf.Abs(movex));

		//movement
		GetComponent<Rigidbody2D>().velocity = new Vector2 (movex * Speed, 0);

		//flipping
		if (movex > 0 &&!facingRight)
			Flip ();
		else if (movex < 0 && facingRight)
			Flip ();
	}
	void Flip()
	{
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
