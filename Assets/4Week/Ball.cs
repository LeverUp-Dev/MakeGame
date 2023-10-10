using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody rigid;
    Transform tr;
    Vector3 originalPosition;

    public float speed;
    public GameManager manager;

    void Awake()
    {
        originalPosition = new Vector3(0, 0.5f, -6);
        rigid = GetComponent<Rigidbody>();
        tr = GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        OnClickShoot();
        ToOriginalPosition();
    }

    void ToOriginalPosition()
    {
        if(tr.position.y < -20)
        {
            rigid.velocity = Vector3.zero;
            tr.rotation = Quaternion.Euler(0, 0, 0);
            tr.position = originalPosition;
            manager.UpdateBallLife();
        }
    }

    void OnClickShoot()
    {
        int ranXRotate = Random.Range(0, -40);
        int ranYRotate = Random.Range(35, -35);

        if(Input.GetMouseButtonDown(0))
        {
            tr.rotation = Quaternion.Euler(ranXRotate, ranYRotate, 0);
            rigid.AddForce(transform.forward * speed);
        }
    }
}
