using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody rigid;

    public float speed;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        rigid.AddForce(transform.forward * speed);
    }
}
