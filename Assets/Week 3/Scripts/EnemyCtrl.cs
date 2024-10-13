using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyCtrl : MMonoBehaviour
{
    [SerializeField] protected NavMeshAgent agent;
    public NavMeshAgent Agent => this.agent;

    [SerializeField] protected Animator animator;
    public Animator Animator => this.animator;

    protected override void GetComponent()
    {
        this.GetEgent();
        this.GetAnimator();
    }

    protected void GetEgent()
    {
        if (this.agent != null) return;
        Debug.Log("LoadComponent", gameObject);
        this.agent = GetComponent<NavMeshAgent>();
    }

    protected void GetAnimator()
    {
        if (this.animator != null) return;
        Debug.Log("LoadComponent", gameObject);
        this.animator = transform.Find("Model").GetComponent<Animator>();
    }
}
