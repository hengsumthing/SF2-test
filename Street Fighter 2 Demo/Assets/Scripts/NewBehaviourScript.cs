using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
	
	public float Speed = 10f;
	private float movex = 10f;
	private float movey = 10f;

	bool hadoken = false;
	bool crouch = false;
	bool MH_punch = false;
	bool H_kick = false;
	bool shouryoken = false;
	public bool facingRight= true;
	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent < Animator> ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		movex = Input.GetAxis ("Horizontal");
		movey = Input.GetAxis ("Vertical");
		hadoken = Input.GetButtonDown("Fire1");
		//trigger walk ani
		anim.SetFloat("Speed", Mathf.Abs(movex));

        //hadoken
		if (Input.GetKeyDown(KeyCode.Z))
		{
		anim.SetBool("Hadoken", true);
		}
		if (Input.GetKeyUp(KeyCode.Z))
		{
			anim.SetBool("Hadoken", false);
		}

		//crouch
		if (Input.GetKeyDown(KeyCode.DownArrow))
		{
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX;
            anim.SetBool("crouch", true);
		}
		if (Input.GetKeyUp(KeyCode.DownArrow))
		{
			anim.SetBool("crouch", false);
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
        }

		//MH_punch
		if (Input.GetKeyDown(KeyCode.X))
		{

			anim.SetBool("MH_punch", true);

		}
		if (Input.GetKeyUp(KeyCode.X))
		{
			anim.SetBool("MH_punch", false);
		}

		//L_kick
		if (Input.GetKeyDown(KeyCode.C))
		{

			anim.SetBool("H_kick", true);

		}
		if (Input.GetKeyUp(KeyCode.C))
		{
			anim.SetBool("H_kick", false);
		}

		//Shouryoken
		if (Input.GetKeyDown(KeyCode.V))
		{
			transform.Translate(Vector3.up * (Speed * Time.deltaTime * 12));
            if (facingRight == true)
            {
                transform.Translate(Vector3.right * (Speed * Time.deltaTime * 5));
                anim.SetBool("Shouryoken", true);
            }
            else if (facingRight == false)
            {
                transform.Translate(Vector3.left * (Speed * Time.deltaTime * 5));
                anim.SetBool("Shouryoken", true);
            }

            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX;

        }
		if (Input.GetKeyUp(KeyCode.V))
		{
            //transform.Translate(Vector3.down * (Speed * Time.deltaTime * 4));
            anim.SetBool("Shouryoken", false);
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
        }

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