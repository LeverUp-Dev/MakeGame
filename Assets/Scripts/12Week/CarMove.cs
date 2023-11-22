using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    public float maxTorque;
    public Transform carCenterPos;
    public WheelCollider[] wheelCols = new WheelCollider[4];
    public Transform[] tireMeshes = new Transform[4];

    void Start()
    {
        GetComponent<Rigidbody>().centerOfMass = carCenterPos.localPosition;
    }

    void FixedUpdate()
    {
        float steer = Input.GetAxisRaw("Horizontal");
        float accelerate = Input.GetAxisRaw("Vertical");
        float finalAngle = steer * 45;
        wheelCols[0].steerAngle = finalAngle;
        wheelCols[1].steerAngle = finalAngle;

        if (Input.GetKey(KeyCode.B))
        {
            foreach (WheelCollider wheel in wheelCols)
            {
                wheel.brakeTorque = maxTorque;
            }
        }
        else
        {
            foreach (WheelCollider wheel in wheelCols)
            {
                wheel.brakeTorque = 0;
                wheel.motorTorque = accelerate * maxTorque;
            }
        }
    }

    void Update()
    {
        for(int i = 0; i < tireMeshes.Length; i++)
        {
            Vector3 pos;
            Quaternion quat;

            wheelCols[i].GetWorldPose(out pos, out quat);

            tireMeshes[i].position = pos;
            tireMeshes[i].rotation = quat;
        }
    }
}