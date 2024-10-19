using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MMonoBehaviour : MonoBehaviour
{
    protected virtual void Reset()
    {
        this.GetComponent();
    }

    protected virtual void Awake()
    {
        this.GetComponent();
    }

    protected virtual void Start()
    {

    }
    protected virtual void GetComponent()
    {
        // For override
    }
}
