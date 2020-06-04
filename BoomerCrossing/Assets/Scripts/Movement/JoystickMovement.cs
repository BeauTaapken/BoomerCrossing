using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickMovement : MonoBehaviour
{
    public GameObject ParentPlanet;

    public float speed = 12f;

    protected Joystick Joystick;
    
    private HittingSide hittingSide = HittingSide.None;

    private Vector3 oldPlayerLocation;

    // Start is called before the first frame update
    void Start()
    {
        Joystick = FindObjectOfType<Joystick>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Joystick.Horizontal;
        float z = Joystick.Vertical;

        transform.position += new Vector3(x * speed , 0, 0) * Time.deltaTime;

        switch (hittingSide)
        {
            case (HittingSide.None):

                ParentPlanet.transform.Rotate(new Vector3(-z, 0, 0) * speed * Time.deltaTime);
                break;

            case (HittingSide.Back):
                
                if (-z < 0)
                {
                    ParentPlanet.transform.Rotate(new Vector3(-z, 0, 0) * speed * Time.deltaTime);
                }
                break;

            case (HittingSide.Front):

                if (-z > 0)
                {
                    ParentPlanet.transform.Rotate(new Vector3(-z, 0, 0) * speed * Time.deltaTime);
                }
                break;

            default:
                Debug.Log("Missing a check");
                break;
        }
    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name != "Planet")
        {
            float angle = Vector3.Angle(collision.contacts[0].normal, Vector3.forward);
            if (angle <= 15)
            {
                hittingSide = HittingSide.Back;
            }
            else if (angle >= 160 && angle <= 180)
            {
                hittingSide = HittingSide.Front;
            }
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name != "Planet")
        {
            hittingSide = HittingSide.None;
        }
    }
}
