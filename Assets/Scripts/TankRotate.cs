using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankRotate : MonoBehaviour
{
    float r;
    public float rotateSpeed;

    void Start()
    {
        r = 0;
    }

    void Update()
    {
        r = Input.GetAxisRaw("Mouse X") * Time.deltaTime * rotateSpeed;

        transform.Rotate(0, r, 0);
    }
}
