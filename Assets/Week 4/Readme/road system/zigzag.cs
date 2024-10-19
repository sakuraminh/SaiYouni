using System;
using UnityEngine;
using UnityEngine.AI;

public class zigzag : MovingBT
{
    protected override void Start()
    {
        base.Start();
        this.setIndex = 1;
    }
}
