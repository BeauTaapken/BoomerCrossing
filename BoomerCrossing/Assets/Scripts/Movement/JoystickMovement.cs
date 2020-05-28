using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickMovement : MonoBehaviour
{
    protected Joystick Joystick;

    public float speed = 12f;
    public float gravity = 9.8f;

    private float vSpeed = 0;

    private CharacterController characterController;

    // Start is called before the first frame update
    void Start()
    {
        Joystick = FindObjectOfType<Joystick>();
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Joystick.Horizontal;
        float z = Joystick.Vertical;

        Vector3 move = transform.right * x + transform.forward * z;

        if (characterController.isGrounded)
        {
            vSpeed = 0;
        }

        vSpeed -= gravity;
        move.y = vSpeed;
        characterController.Move(move * speed * Time.deltaTime);
    }
}
