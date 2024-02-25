using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Navigation : MonoBehaviour
{

    public NavMeshAgent agent;
    public Transform target;
    public float speed;
    public float attack;
    public Animator anim;

    

    void Muwer()

    {
        agent.speed = speed;
        anim.SetBool("Run" , true);
    }
        
    void Stay()

    {
        agent.speed = 0;
        anim.SetBool("Run", false);
    }

    void Update()

    {
        agent.destination = target.position;
        anim.SetFloat("Speed", agent.velocity.magnitude / 2);
        if(agent.remainingDistance > attack)
        {
            Muwer();
        }
        else
        {
            Stay();
        }
    }

}
