using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public GameObject particle;
    AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Arrow")
        {
            audio.Play();
            Object obj = Instantiate(particle, other.transform.position, Quaternion.identity);
            Destroy(obj, 5);
        }
    }
}
