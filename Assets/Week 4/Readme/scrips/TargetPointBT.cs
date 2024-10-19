using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPointBT : MMonoBehaviour
{
    [SerializeField] protected List<Transform> targets = new();
    public List<Transform> Targets => this.targets;

    protected override void GetComponent()
    {
        if (targets.Count != 0) return;

        Debug.Log("Get List", gameObject);
        foreach (Transform child in this.transform)
        {
            this.targets.Add(child);
        }
    }
}
