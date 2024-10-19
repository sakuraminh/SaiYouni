using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class NearbyTargetPlayer : MMonoBehaviour
{
    [SerializeField] protected List<NearbyTargetEnemy> targetList = new();

    protected override void Start()
    {
        base.Start();
        this.SelectionSort();
    }

    protected override void GetComponent()
    {
        this.GetCamponentNearbyTargetEnemy();
    }

    protected virtual void GetCamponentNearbyTargetEnemy()
    {
        if (this.targetList.Count > 0) return;
        Debug.Log("GetComponent");
        foreach (Transform child in GameObject.Find("Enemy").transform)
        {
            targetList.Add(child.GetComponent<NearbyTargetEnemy>());
        }
    }
    protected virtual Transform SelectionSort()
    {
        if (targetList.Count == 0)
        {
            Debug.Log("Null");
            return null;
        }
        float minDistance = targetList[0].DistanceToPlayer;
        Transform minEnemy = targetList[0].transform;

        foreach (NearbyTargetEnemy target in targetList)
        {
            if (target.DistanceToPlayer < minDistance)
            {
                minDistance = target.DistanceToPlayer;
                minEnemy = target.transform;
            }
        }
        Debug.Log("Khoảng cách: " + minDistance);
        Debug.Log("Name: " + minEnemy.name, minEnemy.gameObject);
        this.PrintList();
        return minEnemy;
    }

    protected virtual void PrintList()
    {
        foreach (NearbyTargetEnemy distance in targetList)
        {
            Debug.Log(distance.DistanceToPlayer + distance.name);
        }
    }
}
