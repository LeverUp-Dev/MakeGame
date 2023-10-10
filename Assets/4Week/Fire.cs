using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject bullet;
    public Transform firePos;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, firePos.position, Quaternion.identity);
        }
    }
}
