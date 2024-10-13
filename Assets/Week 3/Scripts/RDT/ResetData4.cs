using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetData4 : ResetData1
{
    protected override void LoadSpeed()
    {
        this.Agent.speed = 0.5f;
    }
}
