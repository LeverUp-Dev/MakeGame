using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("�浹");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("�浹");
    }
}
