using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointWall : MonoBehaviour
{
    public GameManager manager;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ball")
        {
            manager.scorePoint += 3;
            manager.SetScore();
        }
    }
}
