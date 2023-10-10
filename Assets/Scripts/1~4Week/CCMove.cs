using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCMove : MonoBehaviour
{
    CharacterController cc;
    Vector3 xVec, yVec, zVec, sumVec;
    float gravity = 9.8f;
    float y = 0;

    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        zVec = transform.right * 5 * Time.deltaTime * x;
        if(cc.isGrounded == true)
        {
            if (Input.GetButton("Jump"))
            {
                y = 0.1f;
            }

            y = 0;
        }
        else
        {
            y -= gravity * Time.deltaTime;
        }

        yVec = new Vector3(0, y, 0);
        xVec = transform.forward * 5 * Time.deltaTime * z;

        sumVec = xVec + yVec + zVec;
        transform.Rotate(0, Input.GetAxisRaw("Mouse X"), 0);
        cc.Move(sumVec);
    }
}
