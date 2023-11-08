using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideMove : MonoBehaviour
{
    float x = 0;
    Vector3 newPosition;

    public bool isLerp;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
            x += 5;
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
            x -= 5;

        newPosition = new Vector3(20 + x, transform.position.y, transform.position.z);

        if(isLerp)
            transform.position = Vector3.Lerp(transform.position, newPosition, 0.1f);
        else
            transform.position = Vector3.MoveTowards(transform.position, newPosition, 0.1f);
    }
}
