using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetData1 : EnemyCtrl
{
    protected override void Reset()
    {
        base.Reset();
        this.LoadSpeed();
    }

    protected virtual void LoadSpeed()
    {
        this.Agent.speed = 1.5f;
    }
}
