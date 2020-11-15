using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class chasing : MonoBehaviour
{   private NavMeshAgent agent;
    public GameObject player;
    public float range;
    public AnimationClip hit;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

    }

    void Update()
    {   if(Vector3.Distance(player.transform.position,transform.position)< range)
           agent.SetDestination(player.transform.position);
        // (Vector3.Distance(player.transform.position, transform.position) == 1)
            //hit.();

    }
}
