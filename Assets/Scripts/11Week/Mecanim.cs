using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mecanim : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        //if (Input.GetMouseButton(0))
        //{
        //    anim.SetBool("IsRun", true);
        //}
        //else
        //{
        //    anim.SetBool("IsRun", false);
        //}
        if (Input.GetMouseButton(0))
        {
            anim.SetBool("IsRun", true);
        }
        else if (Input.GetMouseButtonDown(2))
        {
            anim.SetBool("IsReady", true);
        }
        else if (Input.GetMouseButton(1))
        {
            anim.SetBool("IsFire", true);
        }
        else
        {
            anim.SetBool("IsRun", false);
            anim.SetBool("IsFire", false);
            anim.SetBool("IsReady", false);
            anim.SetTrigger("Fire");
        }
    }
}
