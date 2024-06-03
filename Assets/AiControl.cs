using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiControl : MonoBehaviour
{

    GameObject []goal;
    NavMeshAgent agent;
    Animator animator;
    int i;
    // Start is called before the first frame update
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
        animator = this.GetComponent<Animator>();
        goal = GameObject.FindGameObjectsWithTag("goal");
         i = Random.Range(0, goal.Length);
        agent.SetDestination(goal[i].transform.position);
        animator.SetTrigger("isWalking");
        float sm = Random.Range(0.5f,1f);
        animator.SetFloat("walkOffset" , sm);
        agent.speed *= sm;

    }

    private void Update()
    {
        
        if(agent.remainingDistance < 1)
        {
            i = Random.Range(0, goal.Length);
            agent.SetDestination(goal[i].transform.position);
        }
    }

}
