using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationcontrols : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool isRunning = animator.GetBool("isRunning");
        bool forwardPressed = Input.GetKey("up");

        if (!isRunning && forwardPressed) {
            animator.SetBool("isRunning", true);
        }

        if (isRunning && !forwardPressed) {
            animator.SetBool("isRunning", false);
        }
        
    }
}
