using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMove : MonoBehaviour
{
    float x, y, z;
    public float speed;

    void Start()
    {
        x = 0;
        y = 0;
        z = 0;
    }

    void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        z = Input.GetAxisRaw("Vertical");
        y = Input.GetAxisRaw("Jump");

        Vector3 moveVec = new Vector3(x, y, z).normalized * Time.deltaTime * speed;
        transform.Translate(moveVec);
    }
}
