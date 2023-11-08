using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove2 : MonoBehaviour
{
    int dist = 4;
    int height = 3;
    public Transform player;
    Vector3 offset;

    void LateUpdate()
    {
        offset = player.forward * dist + Vector3.down * height;
        //transform.position = Vector3.Lerp(transform.position, player.position - offset, 0.05f); //a에서 b로 프레임마다 0.05(5%)만큼 이동
        transform.position = Vector3.Slerp(transform.position, player.position - offset, Time.deltaTime);
        transform.LookAt(player);
    }
}
