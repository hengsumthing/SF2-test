using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour {
	public static float speed=10f;
	public static float movex;
	public static float movey = 10f;
	public static bool facingRight= true;
	public static Animator anim;
    public static int keyTimeOut = 0;
    public static bool isAttacking = false;
    public static Rigidbody2D r2d;
	public bool grounded = false;
	public Transform groundCheck;
	public float groundRadius = 0.2f;
	public LayerMask whatIsGround;
	public float jumpForce = 700;
	public bool jump = false;


    // Use this for initialization
    void Start () {
		anim = GetComponent < Animator> ();
        r2d = GetComponent<Rigidbody2D>();


    }
	
	// Update is called once per frame
	void FixedUpdate () {
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);
		anim.SetBool ("Ground", grounded);
		anim.SetFloat ("vSpeed", r2d.velocity.y);

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

	void Update(){
		if (grounded && Input.GetKeyDown (KeyCode.UpArrow)) {

				anim.SetBool ("Ground", false);
				r2d.AddForce (new Vector2 (0, jumpForce));
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
