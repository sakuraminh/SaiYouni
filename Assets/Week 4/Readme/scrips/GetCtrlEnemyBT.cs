using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCtrlEnemyBT : MMonoBehaviour
{
    [SerializeField] protected EnemyCtrlBT enemyCtrl;
    public EnemyCtrlBT EnemyCtrl => this.enemyCtrl;

    protected override void GetComponent()
    {
        this.GetEnemyCtrl();
    }

    protected void GetEnemyCtrl()
    {
        if (this.enemyCtrl != null) return;
        Debug.Log("LoadComponent", gameObject);
        this.enemyCtrl = GetComponentInParent<EnemyCtrlBT>();
    }
}
