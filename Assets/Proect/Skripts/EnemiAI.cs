using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EnemiAI : MonoBehaviour {
    public AudioClip targetSound, bust;
	public float stopDist, speed = 10;
	public Animator anim;
	public Transform[] target;
	public NavMeshAgent agent;
    public bool warior { get; set; }
    private int num;
    private float tim;
    private void Start()
    {
        Box.stopTarget += Muwe;
        agent.speed = speed;
        gameObject.SetActive(false);
    }
    private void OnDestroy()
    {
        Box.stopTarget -= Muwe;
    }
    public void Target()
    {
        if (!warior)
        {
            SoundPlayer.regit.Play(bust, 2);
            warior = true;
        }
        anim.SetBool("Walck", true);
    }
    public void Busted()
    {
        warior = false;
        SoundPlayer.regit.Play(targetSound,2);
        var looker = Muwer.rid.transform.position - transform.position;
        looker.y = 0;
        transform.rotation = Quaternion.LookRotation(looker);
        Interface.rid.GamOver();
    }
    public void Muwe()
    {
        agent.speed = speed;
        warior = false;
        agent.destination = target[num].position;
        agent.isStopped = false;
        anim.SetBool("Walck", true);
    }
    void State()
    {
        agent.isStopped = true;
        anim.SetBool("Walck", false);
    }
    public void Deaktivate()
    {
        agent.isStopped = true;
        anim.SetFloat("Speed", 0);
        anim.SetBool("Ded", true);
        Destroy(this);
    }
    void Update () {
        anim.SetFloat ("Speed", agent.velocity.magnitude);
        if (!warior)
        {
            if (tim < Time.time)
            {
                if (Vector3.Distance(target[num].position, transform.position) <= stopDist)
                {
                    State();
                    tim = Time.time + 4;
                    if (num < target.Length - 1)
                    {
                        num += 1;
                    }
                    else
                    {
                        num = 0;
                    }
                }
                else
                {
                    Muwe();
                }
            }
        }
        else
        {
            agent.destination = Muwer.rid.transform.position;
            agent.isStopped = false;
            agent.speed = speed * 2;
            if (Vector3.Distance(Muwer.rid.transform.position, transform.position) <= stopDist)
            {
                State();
            }
        }
    }
}
