using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour {
    public GameObject fireBall;
    public Transform fireSpawn;
    public float speed;
    private Rigidbody2D rBody;
    // Use this for initialization
    void Start () {
        rBody = this.GetComponent<Rigidbody2D>();
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
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Instantiate(fireBall, fireSpawn.position, fireSpawn.rotation);
        }
    }
}
