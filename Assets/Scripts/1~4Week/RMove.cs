using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RMove : MonoBehaviour
{
    Rigidbody rigid;
    float x, z;

    public float speed;

    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        x = Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed;
        z = Input.GetAxisRaw("Vertical") * Time.deltaTime * speed;

        rigid.AddForce(x, 0, z);
    }
}
