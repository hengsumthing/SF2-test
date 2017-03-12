using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : character {
    public GameObject fireBall;

    public Transform fireSpawn;
    private Rigidbody2D rBody;
    private float nextFire = 1.5f;
    private float myTime = 0.0f;
    public float fireDelta = 0.5f;

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
        
    }

    void Update()
    {
        myTime = myTime + Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.C) && myTime > nextFire && anim.GetBool("Hadoken")==true) 
        {
            fireBall.SetActive(true);
            Instantiate(fireBall, fireSpawn.position, fireSpawn.rotation);
            nextFire = myTime + fireDelta;
            
           

            nextFire = nextFire - myTime;
            myTime = 0.0f;
        }




        /*if (Input.GetKeyDown(KeyCode.C))
        {

            fireBall.SetActive(true);
            Instantiate(fireBall, fireSpawn.position, fireSpawn.rotation);
        }*/
    }
    void Flipball()
    {
        Vector3 newScale = fireBall.transform.localScale;
        newScale.x *= -1;
        fireBall.transform.localScale = newScale;
    }
}




