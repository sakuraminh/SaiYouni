using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class MoveInAStraightLine : MovingBT
{
    protected override void Start()
    {
        base.Start();
        this.setIndex = 4;
    }
}
