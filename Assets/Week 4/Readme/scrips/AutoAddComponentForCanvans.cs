using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AutoAddComponentForCanvans : MMonoBehaviour
{
    protected override void Awake()
    {
        this.AutoAddConponent();
        base.Awake();
    }

    protected virtual void AutoAddConponent()
    {
        Debug.Log("Auto add component", gameObject);
        gameObject.AddComponent<CanvasCtrl>();
    }
}
