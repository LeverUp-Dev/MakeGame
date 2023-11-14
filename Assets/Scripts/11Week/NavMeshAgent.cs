using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshAgent : MonoBehaviour
{
    public Transform Player;
    NavMeshAgent navMeshAgent;
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        //navMeshAgent.destination = Player.position;
        //navMeshAgent
    }
}
