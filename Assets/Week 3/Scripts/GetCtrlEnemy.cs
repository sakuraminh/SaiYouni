using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCtrlEnemy : MMonoBehaviour
{
    [SerializeField] protected EnemyCtrl enemyCtrl;
    public EnemyCtrl EnemyCtrl => this.enemyCtrl;

    protected override void GetComponent()
    {
        this.GetEnemyCtrl();
    }

    protected void GetEnemyCtrl()
    {
        if (this.enemyCtrl != null) return;
        Debug.Log("LoadComponent", gameObject);
        this.enemyCtrl = GetComponentInParent<EnemyCtrl>();
    }
}
