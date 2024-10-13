using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetData2 : ResetData1
{
    protected override void LoadSpeed()
    {
        this.Agent.speed = 5f;
    }
}
