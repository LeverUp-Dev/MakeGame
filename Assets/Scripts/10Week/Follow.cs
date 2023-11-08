using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform target;
    Transform tr;

    void Start()
    {
        tr = GetComponent<Transform>();
        float yAngle = Mathf.LerpAngle(tr.eulerAngles.y, target.eulerAngles.y, Time.deltaTime);
        Quaternion rot = Quaternion.Euler(0f, yAngle, 0f);

        //transform.position = target.position;
        transform.position = target.position - (Vector3.forward * 4);
    }
}
