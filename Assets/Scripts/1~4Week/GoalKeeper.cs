using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalKeeper : MonoBehaviour
{
    float x;
    public float speed;
    
    void Update()
    {
        x = transform.position.x;
        if (x > 3.2f)
        {
            speed = -speed;
        }
        else if (x < -3.2f)
        {
            speed = -speed;
        }
        x += Time.deltaTime * speed;
        transform.position = new Vector3(x, 0, 4);
    }
}
