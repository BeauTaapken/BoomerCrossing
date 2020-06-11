using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickMovement : MonoBehaviour
{
    public float speed = 12f;
    public float gravity = 9.8f;

    protected Joystick Joystick;

    private CharacterController characterController;
    public Animator animator;

    private Vector3 oldPlayerLocation;

    private float vSpeed = 0;

    // Start is called before the first frame update
    void Start()
    {
        Joystick = FindObjectOfType<Joystick>();
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        int Direct = 0;
        float x = Joystick.Horizontal;
        float z = Joystick.Vertical;
        animator.SetFloat("X",x);
        animator.SetFloat("Z",z);

        if(x > 0.01f && x > Mathf.Abs(z))
        {
            Direct = 2;
        }
        else if(x < -0.01f && x > Mathf.Abs(z))
        {
            Direct = 4;
        }
        else if(z > 0.01f )
        {
            Direct = 1;
        }
        else if(z < -0.01f )
        {
            Direct = 3;
        }
        animator.SetInteger("Direct",Direct);


        transform.position += new Vector3(x * speed , 0, 0) * Time.deltaTime;

        Vector3 move = transform.right * x + transform.forward * z;

        if (characterController.isGrounded)
        {
            vSpeed = 0;
            //If jumping will be added, add here with an if statement on getaxis
        }

        vSpeed -= gravity;
        move.y = vSpeed;
        characterController.Move(move * speed * Time.deltaTime);

        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
