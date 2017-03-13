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
        //shouryuken
        if (Input.GetKeyDown(KeyCode.X))
            {
             if (keyTimeOut == 0)
             {
                keyTimeOut =100;
                anim.SetBool("Shouryuken", true);
				r2d.AddForce(new Vector2(0,jumpForce));
                  isAttacking = true; 
             }
         }
         if (keyTimeOut != 0)
         {
                keyTimeOut --;
            }
            else if (keyTimeOut == 0)
            {
                anim.SetBool("Shouryuken", false);
               isAttacking = false;
            }


        //spinykick
		if (Input.GetKeyDown(KeyCode.Z))
        {
            if (keyTimeOut == 0)
            {
                keyTimeOut = 70;
                anim.SetBool("spinykick", true);
                isAttacking = true;
            }
        }
        if (keyTimeOut != 0)
        {
            keyTimeOut--;
        }
        else if (keyTimeOut == 0)
        {
            anim.SetBool("spinykick", false);
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
        //L_kick
		if (Input.GetKeyDown(KeyCode.A) && movex == 0 || Input.GetKeyDown(KeyCode.Joystick1Button0) && movex == 0)
        {
            if (keyTimeOut == 0)
            {
                keyTimeOut = 25;
                anim.SetBool("LM_kick", true);
                isAttacking = true;
            }
        }
        else if (keyTimeOut == 0)
        {
            anim.SetBool("LM_kick", false);
            isAttacking = false;
        }
        //m_kick
		if (Input.GetKeyDown(KeyCode.S) && movex == 0 || Input.GetKeyDown(KeyCode.JoystickButton1) && movex == 0)
        {
            if (keyTimeOut == 0)
            {
                keyTimeOut = 25;
                anim.SetBool("LM_kick", true);
                isAttacking = true;
            }
        }
        else if (keyTimeOut == 0)
        {
            anim.SetBool("H_kick", false);
            isAttacking = false;
        }
        //h_kick
		if (Input.GetKeyDown(KeyCode.D) && movex == 0 || Input.GetKeyDown(KeyCode.JoystickButton4) && movex == 0)
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

        //forward_H_kick
		if (Input.GetKeyDown(KeyCode.D) && movex != 0 || Input.GetKeyDown(KeyCode.JoystickButton4) && movex != 0)
        {
            if (keyTimeOut == 0)
            {
                keyTimeOut = 50;
                anim.SetBool("forward_H_kick", true);
                isAttacking = true;
            }
        }
        else if (keyTimeOut == 0)
        {
            anim.SetBool("forward_H_kick", false);
            isAttacking = false;
        }
        if (anim.GetBool("forward_H_kick") == true)
        {
            isAttacking = true;
        }

        //forward_M_kick
		if (Input.GetKeyDown(KeyCode.S) && movex != 0 || Input.GetKeyDown(KeyCode.JoystickButton1) && movex != 0)
        {
            if (keyTimeOut == 0)
            {
                keyTimeOut = 30;
                anim.SetBool("forward_M_kick", true);
                isAttacking = true;
            }
        }
        else if (keyTimeOut == 0)
        {
            anim.SetBool("forward_M_kick", false);
            isAttacking = false;
        }
        if (anim.GetBool("forward_M_kick") == true)
        {
            isAttacking = true;
        }

        //forward_L_kick
		if (Input.GetKeyDown(KeyCode.A) && speed != 0 || Input.GetKeyDown(KeyCode.JoystickButton1) && movex != 0)
        {
            if (keyTimeOut == 0)
            {
                keyTimeOut = 30;
                anim.SetBool("forward_L_kick", true);
                isAttacking = true;
            }
        }
        else if (keyTimeOut == 0)
        {
            anim.SetBool("forward_L_kick", false);
            isAttacking = false;
        }
        if (anim.GetBool("forward_L_kick") == true)
        {
            isAttacking = true;
        }


        //L_punch
		if (Input.GetKeyDown(KeyCode.Q) && movex == 0 || Input.GetKeyDown(KeyCode.JoystickButton2) && movex == 0)
        {
            if (keyTimeOut == 0)
            {
                keyTimeOut = 10;
                anim.SetBool("L_punch", true);
                isAttacking = true;
            }
        }
        else if (keyTimeOut == 0)
        {
            anim.SetBool("L_punch", false);
            isAttacking = false;
        }

        //M_punch
		if (Input.GetKeyDown(KeyCode.W) && movex == 0 || Input.GetKeyDown(KeyCode.JoystickButton3) && movex == 0)
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

        //H_punch
		if (Input.GetKeyDown(KeyCode.E) && movex == 0 || Input.GetKeyDown(KeyCode.JoystickButton5) && movex == 0)
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
        //forward_H_punch
		if (Input.GetKeyDown(KeyCode.E) && movex != 0 || Input.GetKeyDown(KeyCode.JoystickButton5) && movex != 0)
        {
            if (keyTimeOut == 0)
            {
                keyTimeOut = 30;
                anim.SetBool("forward_H_punch", true);
                isAttacking = true;
            }
        }
        else if (keyTimeOut == 0)
        {
            anim.SetBool("forward_H_punch", false);
            isAttacking = false;
        }
        if (anim.GetBool("forward_H_punch") == true)
        {   
            isAttacking = true;
        }

        //forward_M_punch
		if (Input.GetKeyDown(KeyCode.W) && movex != 0  || Input.GetKeyDown(KeyCode.JoystickButton3) && movex != 0)
        {
            if (keyTimeOut == 0)
            {
                keyTimeOut = 30;
                anim.SetBool("forward_M_punch", true);
                isAttacking = true;
            }
        }
        else if (keyTimeOut == 0)
        {
            anim.SetBool("forward_M_punch", false);
            isAttacking = false;
        }
        if (anim.GetBool("forward_M_punch") == true)
        {
            isAttacking = true;
        }

        //forward_L_punch
		if (Input.GetKeyDown(KeyCode.Q) && speed != 0 || Input.GetKeyDown(KeyCode.JoystickButton0) && movex != 0)
        {
            if (keyTimeOut == 0)
            {
                keyTimeOut = 30;
                anim.SetBool("forward_L_punch", true);
                isAttacking = true;
            }
        }
        else if (keyTimeOut == 0)
        {
            anim.SetBool("forward_L_punch", false);
            isAttacking = false;
        }
        if (anim.GetBool("forward_L_punch") == true)
        {
            isAttacking = true;
        }
        //crouch
		if (Input.GetKeyDown(KeyCode.DownArrow) && movex == 0)
        {
            if (keyTimeOut == 0)
            {
                keyTimeOut = 10;
                anim.SetBool("crouch", true);
                isAttacking = true;
            }
        }
        else if (keyTimeOut == 0 && (Input.GetKeyUp(KeyCode.DownArrow)))
        {
                anim.SetBool("crouch", false);
        }
        if (anim.GetBool("crouch") == true)
        {
            isAttacking = true;
        }
    }
}
