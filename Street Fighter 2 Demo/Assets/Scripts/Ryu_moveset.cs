using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ryu_moveset : character {
    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
 
    }
	
	// Update is called once per frame
	void Update () {
        if (isAttacking == true)
        {
            r2d.constraints = RigidbodyConstraints2D.FreezePositionX;
        }
        else if (isAttacking == false)
        {
            r2d.constraints = RigidbodyConstraints2D.None;
        }
        //shouryoken
        if (Input.GetKeyDown(KeyCode.V))
            {
             if (keyTimeOut == 0)
             {
                keyTimeOut =63;
                  anim.SetBool("Shouryoken", true);
                  isAttacking = true; 
             }
         }
         if (keyTimeOut != 0)
         {
                keyTimeOut --;
            }
            else if (keyTimeOut == 0)
            {
                anim.SetBool("Shouryoken", false);
               isAttacking = false;
            }

        //hadoken
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (keyTimeOut == 0)
            {
                keyTimeOut = 30;
                anim.SetBool("Hadoken", true);
                isAttacking = true;
            }
        }
        else if (keyTimeOut == 0)
        {
            anim.SetBool("Hadoken", false);
            isAttacking = false;
        }

        //h_kick
        if (Input.GetKeyDown(KeyCode.X))
        {
            if (keyTimeOut == 0)
            {
                keyTimeOut = 30;
                anim.SetBool("H_kick", true);
                isAttacking = true;
            }
        }
        else if (keyTimeOut == 0)
        {
            anim.SetBool("H_kick", false);
            isAttacking = false;
        }

        //MH_punch
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (keyTimeOut == 0)
            {
                keyTimeOut = 10;
                anim.SetBool("MH_punch", true);
                isAttacking = true;
            }
        }
        else if (keyTimeOut == 0)
        {
            anim.SetBool("MH_punch", false);
            isAttacking = false;
        }
    }
}
