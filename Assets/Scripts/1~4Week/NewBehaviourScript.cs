using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("충돌");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("충돌");
    }
}
