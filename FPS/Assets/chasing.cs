using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class chasing : MonoBehaviour
{   private NavMeshAgent agent;
    public GameObject player;
    public float range;
    public Animator anim;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        anim.SetBool("Range", false);

    }

    void Update()
    {   if(Vector3.Distance(player.transform.position,transform.position)< range)
           agent.SetDestination(player.transform.position);
         if (Vector3.Distance(player.transform.position, transform.position) >= 1)
        {
            anim.SetBool("Range", true);
        }
            


    }
}
