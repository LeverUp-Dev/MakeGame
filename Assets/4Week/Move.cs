using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Transform tr;
    public float speed;
    public float rotateSpeed;
    float x, y, z;

    void Start()
    {
        tr = GetComponent<Transform>();
    }

    void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        z = Input.GetAxisRaw("Vertical");
        y = Input.GetAxisRaw("Mouse X");

        Vector3 moveVec = new Vector3(x, 0, z).normalized * Time.deltaTime * speed;

        tr.Translate(moveVec);

        tr.Rotate(new Vector3(0, y, 0)*Time.deltaTime*rotateSpeed);
    }
}
