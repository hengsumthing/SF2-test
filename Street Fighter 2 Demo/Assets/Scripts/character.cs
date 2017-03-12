using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour {
	public static float speed=10f;
	public static float movex = 10f;
	public static float movey = 10f;
	public static bool facingRight= true;
	public static Animator anim;
    public static int keyTimeOut = 0;
    public static bool isAttacking = false;
    public static Rigidbody2D r2d;




    // Use this for initialization
    void Start () {
		anim = GetComponent < Animator> ();
        r2d = GetComponent<Rigidbody2D>();


    }
	
	// Update is called once per frame
	void FixedUpdate () {
		
		movex = Input.GetAxis ("Horizontal");
		movey = Input.GetAxis ("Vertical");
		//trigger walk ani
		anim.SetFloat("Speed", Mathf.Abs(movex));
		//movement
		GetComponent<Rigidbody2D>().velocity = new Vector2 (movex * speed, 0);

        //flipping
        if (isAttacking == false)
        {
            if (movex > 0 && !facingRight)
                Flip();
            else if (movex < 0 && facingRight)
                Flip();
        }
	}
	void Flip()
	{
            facingRight = !facingRight;
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;


	}
}
