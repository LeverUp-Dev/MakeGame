using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireShoot : MonoBehaviour
{
    public Transform firePos;
    public GameObject bullet;
    public GameObject arrow;

    void Update()
    {
        Shot();
    }

    void Shot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Object obj = Instantiate(bullet, firePos.position, firePos.rotation);
            Destroy(obj, 4f);
        }
        else if(Input.GetMouseButtonDown(1))
        {
            Object obj = Instantiate(arrow, firePos.position, firePos.rotation);
            Destroy(obj, 4f);
        }
    }
}
