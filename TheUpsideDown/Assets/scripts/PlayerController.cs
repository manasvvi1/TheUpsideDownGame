using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;

    //public Rigidbody theRB;
    public float jumpForce;

    public CharacterController controller;

    private Vector3 moveDirection;

    public float gravityScale;

    public Transform pivot;

    public float rotateSpeed;

    public GameObject playerModel;

    public float knockBackForce;

    public float knockBackTime;

    private float knockBackCounter;

    

    // Start is called before the first frame update
    void Start()
    {
        //theRB = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {   
        
        Vector3 movementDirection = new Vector3(Input.GetAxis("Horizontal"),0, Input.GetAxis("Vertical"));

        if(movementDirection!=Vector3.zero )
        {
            playerModel.transform.rotation = Quaternion.LookRotation(movementDirection*(-1));
        }
        else
        {
            Vector3 lookForward;
            lookForward.x=0;
            lookForward.y=0;
            lookForward.z=-1f;
            playerModel.transform.rotation = Quaternion.LookRotation(lookForward);
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //theRB.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, theRB.velocity.y, Input.GetAxis("Vertical") * moveSpeed);
        /*if(Input.GetButtonDown("Jump"))
        {
            theRB.velocity = new Vector3(theRB.velocity.x , jumpForce, theRB.velocity.z);
        }*/
        //moveDirection = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, 0f, Input.GetAxis("Vertical") * moveSpeed);
        if (knockBackCounter <= 0)
        {
            float yStore = moveDirection.y;
            moveDirection =
                (transform.forward * Input.GetAxis("Vertical")) +
                (transform.right * Input.GetAxis("Horizontal"));
            moveDirection = moveDirection.normalized * moveSpeed;
            moveDirection.y = yStore;

            if (controller.isGrounded)
            {
                if (Input.GetButtonDown("Jump"))
                {
                    
                    moveDirection.y = jumpForce;
                }
            }
        }
        else
        {
            knockBackCounter -= Time.deltaTime;
        }

        moveDirection.y =
            moveDirection.y +
            (Physics.gravity.y * gravityScale * Time.deltaTime);
        controller.Move(moveDirection * Time.deltaTime);

        //Move the player in different directions based on the camera look
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            transform.rotation =
                Quaternion.Euler(0f, pivot.rotation.eulerAngles.y, 0f);
            Quaternion newRotation =
                Quaternion
                    .LookRotation(new Vector3(moveDirection.x,
                        0f,
                        moveDirection.z));
            playerModel.transform.rotation =
                Quaternion
                    .Slerp(playerModel.transform.rotation,
                    newRotation,
                    rotateSpeed * Time.deltaTime);
        }
    }

    public void Knockback(Vector3 direction)
    {
     
        knockBackCounter = knockBackTime;

        moveDirection=direction*knockBackForce;
        moveDirection.y=knockBackForce;

    }
    
        
    
}