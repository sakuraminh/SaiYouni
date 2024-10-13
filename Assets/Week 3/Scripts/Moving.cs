using System;
using UnityEngine;
using UnityEngine.AI;

public class Moving : GetCtrlEnemy
{
    [SerializeField] protected TargetPoint targetPoint;
    [SerializeField] protected int targetIndex = 0;
    [SerializeField] protected float distance = Mathf.Infinity;
    [SerializeField] protected float distanceLimit = 2;
    [SerializeField] protected bool isFinish = false;
    [SerializeField] protected bool isMoving = false;


    private void FixedUpdate()
    {
        this.MovingToTarget();
    }

    protected override void GetComponent()
    {
        base.GetComponent();
        this.GetTargetPoint();
    }

    private void GetTargetPoint()
    {
        if (this.targetPoint != null) return;
        Debug.Log("LoadComponent", gameObject);
        this.targetPoint = GameObject.Find("TargetPoint").GetComponent<TargetPoint>();
    }

    protected virtual void MovingToTarget()
    {
        this.MovingStatus();
        if (this.isFinish)
        {
            this.enemyCtrl.Agent.isStopped = this.isFinish;
            Debug.Log("Finish", gameObject);
            return;
        }
        this.enemyCtrl.Agent.SetDestination(this.targetPoint.Targets[this.targetIndex].transform.position);
        this.GetNextPoint();
    }

    protected void GetNextPoint()
    {
        this.GetDistance();
        if (this.distance < this.distanceLimit) this.targetIndex++;
        if (this.targetIndex > this.targetPoint.Targets.Count - 1) this.isFinish = true;
    }

    protected void GetDistance()
    {
        this.distance = Vector3.Distance(this.transform.position, this.targetPoint.Targets[this.targetIndex].transform.position);
    }

    protected virtual void MovingStatus()
    {
        this.isMoving = !EnemyCtrl.Agent.isStopped;
        this.EnemyCtrl.Animator.SetBool("isMoving", this.isMoving);
    }
}
