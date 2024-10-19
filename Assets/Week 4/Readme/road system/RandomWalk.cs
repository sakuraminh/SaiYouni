using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomWalk : MovingBT
{
    [SerializeField] protected int numberRandom;

    protected override void Start()
    {
        base.Start();
        this.RandomNumber();
    }
    protected virtual void GetIndex()
    {
        this.numberRandom = this.targetPoint.Targets.Count;
    }

    protected virtual void RandomNumber()
    {
        this.numberRandom = Random.Range(0, this.targetPoint.Targets.Count);
    }
    protected override void MovingToTarget()
    {
        this.enemyCtrl.Agent.SetDestination(this.targetPoint.Targets[this.numberRandom].transform.position);
        this.GetNextPoint();
    }

    protected override void GetNextPoint()
    {
        this.GetDistance();
        if (this.distance < this.distanceLimit) this.RandomNumber();
    }
    protected override void GetDistance()
    {
        this.distance = Vector3.Distance(this.transform.position, this.targetPoint.Targets[this.numberRandom].transform.position);
    }
}
