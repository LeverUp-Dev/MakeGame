using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadRotate : MonoBehaviour
{
    float r;
    float speed = 1000;

    void Start()
    {
        r = 0;
    }

    void Update()
    {
        r = Input.GetAxisRaw("Mouse ScrollWheel") * Time.deltaTime * speed;
        transform.Rotate(r, 0, 0);
    }
}
