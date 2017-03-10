using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour {
    public GameObject fireBall;
    public Transform fireSpawn;
    public float speed;
    private Rigidbody2D rBody;
	private bool fireRight = false;
    // Use this for initialization
    void Start () {
        rBody = this.GetComponent<Rigidbody2D>();
		fireBall.SetActive (false);
	}
	
	// Update is called once per frame

        void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");


        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
     
        rBody.velocity = ( movement* speed);
		GetComponent<Rigidbody2D>().velocity = new Vector2 (movex * Speed, 0);
		//flipping
		if (movex > 0 &&!facingRight)
			Flip ();
		else if (movex < 0 && facingRight)
			Flip ();
		
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
			Instantiate(fireBall, fireSpawn.position, fireSpawn.rotation);
			fireBall.SetActive (true);
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
