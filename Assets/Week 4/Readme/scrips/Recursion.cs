using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Recursion : MMonoBehaviour
{
    protected virtual void OnEnable()
    {
        this.CheckActiveSelf();

        this.Exercise();
    }
    protected void ForOnEnable()
    {
        this.CheckActiveSelf();
    }
    protected virtual void CheckActiveSelf()
    {
        foreach (Transform sibling in transform.parent)
        {
            if (sibling.gameObject.name == gameObject.name) continue;
            if (!sibling.gameObject.activeSelf) continue;
            sibling.gameObject.SetActive(false);
        }
    }

    protected abstract void Exercise();
}
