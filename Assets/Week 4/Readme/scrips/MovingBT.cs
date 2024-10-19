using System;
using UnityEngine;
using UnityEngine.AI;

public class MovingBT : GetCtrlEnemyBT
{
    [SerializeField] protected TargetPointBT targetPoint;
    [SerializeField] protected int targetIndex = 0;
    [SerializeField] protected float distance = Mathf.Infinity;
    [SerializeField] protected float distanceLimit = 2;
    [SerializeField] protected bool isFinish = false;
    [SerializeField] protected int setIndex = 0;


    protected virtual void FixedUpdate()
    {
        this.MovingToTarget();
    }

    protected override void GetComponent()
    {
        base.GetComponent();
        this.GetTargetPoint();
    }

    protected virtual void GetTargetPoint()
    {
        if (this.targetPoint != null) return;
        Debug.Log("LoadComponent", gameObject);
        this.targetPoint = GameObject.Find("PrefabPoint").GetComponent<TargetPointBT>();
    }

    protected virtual void MovingToTarget()
    {
        if (this.enemyCtrl.Agent.isStopped) return;
        if (this.isFinish)
        {
            this.enemyCtrl.Agent.isStopped = this.isFinish;
            Debug.Log("Finish", gameObject);
            return;
        }
        this.enemyCtrl.Agent.SetDestination(this.targetPoint.Targets[this.targetIndex].transform.position);
        this.GetNextPoint();
    }

    protected virtual void GetNextPoint()
    {
        this.GetDistance();
        if (this.distance < this.distanceLimit) this.targetIndex++;
        if (this.targetIndex > this.targetPoint.Targets.Count - setIndex) this.isFinish = true;
    }

    protected virtual void GetDistance()
    {
        this.distance = Vector3.Distance(this.transform.position, this.targetPoint.Targets[this.targetIndex].transform.position);
    }
}
