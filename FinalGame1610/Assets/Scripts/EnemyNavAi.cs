using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//Integrated from School Lessons
public class EnemyNavAi : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;
    
    
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    
    void Update()
    {
        agent.destination = player.position;
    }
}
