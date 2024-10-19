using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class NearbyTargetPlayer2D : MMonoBehaviour
{
    [SerializeField] protected List<NearbyTargetItem2D> targetList = new();

    protected override void Start()
    {
        base.Start();
        this.GetMinDistance();
    }

    protected override void GetComponent()
    {
        this.GetCamponentNearbyTargetItem2D();
    }

    protected virtual void GetCamponentNearbyTargetItem2D()
    {
        if (this.targetList.Count > 0) return;
        Debug.Log("GetComponent");
        foreach (Transform child in GameObject.Find("Item").transform)
        {
            targetList.Add(child.GetComponent<NearbyTargetItem2D>());
        }
    }
    protected virtual Transform GetMinDistance()
    {
        if (targetList.Count == 0)
        {
            Debug.Log("Null");
            return null;
        }
        float minDistance = targetList[0].DistanceToPlayer;
        Transform minItem = targetList[0].transform;

        foreach (NearbyTargetItem2D target in targetList)
        {
            if (target.DistanceToPlayer < minDistance)
            {
                minDistance = target.DistanceToPlayer;
                minItem = target.transform;
            }
        }
        Debug.Log("Khoảng cách: " + minDistance);
        Debug.Log("Name: " + minItem.name, minItem.gameObject);
        this.PrintList();
        return minItem;
    }

    protected virtual void PrintList()
    {
        foreach (NearbyTargetItem2D distance in targetList)
        {
            Debug.Log(distance.DistanceToPlayer + distance.name);
        }
    }
}
