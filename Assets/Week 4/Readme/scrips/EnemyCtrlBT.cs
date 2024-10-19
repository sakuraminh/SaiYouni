using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyCtrlBT : MMonoBehaviour
{
    [SerializeField] protected NavMeshAgent agent;
    public NavMeshAgent Agent => this.agent;

    [SerializeField] protected Animator animator;
    public Animator Animator => this.animator;

    protected override void GetComponent()
    {
        this.GetEgent();
    }

    protected void GetEgent()
    {
        if (this.agent != null) return;
        Debug.Log("LoadComponent", gameObject);
        this.agent = GetComponent<NavMeshAgent>();
    }
    protected virtual void LoadAnimator()
    {
        if (this.animator != null) return;
        this.animator = transform.Find("Model").GetComponent<Animator>();
        Debug.Log(transform.name + ": LoadAnimator", gameObject);
    }
}
