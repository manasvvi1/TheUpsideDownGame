using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlendTreeAnimations : MonoBehaviour
{
    Animator animator;
    float velocityZ = 0.0f;
    float velocityX = 0.0f;
    public float acceleration = 2.0f;
    public float deceleration = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool forwardPressed = Input.GetKey("w") || Input.GetKey("up");
        bool rightPressed = Input.GetKey("d") || Input.GetKey("right");
        bool leftPressed = Input.GetKey("a") || Input.GetKey("left");
        bool backPressed = Input.GetKey("s") || Input.GetKey("down");

        if (forwardPressed && velocityZ < 0.5f) {
            velocityZ += Time.deltaTime * acceleration;
        }

        if (leftPressed && velocityX > -0.5f) {
            velocityX -= Time.deltaTime * acceleration;
        }

        if(rightPressed && velocityX < 0.5f) {
            velocityX += Time.deltaTime * acceleration;
        }

        if (backPressed && velocityZ > -0.5f) {
            velocityZ -= Time.deltaTime * acceleration;
        }

        if (!forwardPressed && velocityZ > 0.0f) {
            velocityZ -= Time.deltaTime * deceleration;
        }

        if (!backPressed && velocityZ < 0.0f) {
            velocityZ += Time.deltaTime * deceleration;
        }

        if (!forwardPressed && !backPressed && velocityZ != 0.0f && (velocityZ > -0.05f && velocityZ < 0.05f)) {
            velocityZ = 0.0f;
        }

        if (!leftPressed && velocityX < 0.0f) {
            velocityX += Time.deltaTime * deceleration;
        }

        if (!rightPressed && velocityX > 0.0f) {
            velocityX -= Time.deltaTime * deceleration;
        }

        if (!leftPressed && !rightPressed && velocityX != 0.0f && (velocityX > -0.05f && velocityX < 0.05f)) {
            velocityX = 0.0f;
        }

        animator.SetFloat("velocityZ", velocityZ);
        animator.SetFloat("velocityX", velocityX);
    }
}