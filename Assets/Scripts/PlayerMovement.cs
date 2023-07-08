using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("Crouching", Input.GetKey("down"));
        if (Input.GetKeyDown("up"))
        {
            animator.ResetTrigger("Jump");
            animator.SetTrigger("Jump");
        }
    }
}
