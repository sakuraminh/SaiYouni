using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NearbyTargetEnemy : MMonoBehaviour
{

    protected float x = default;
    protected float y = 2;
    protected float z = default;
    [SerializeField] protected Transform player;
    [SerializeField] protected float distanceToPlayer;
    public float DistanceToPlayer => distanceToPlayer;

    protected override void Awake()
    {
        base.Awake();
        base.Start();
        this.RandomXY();
        this.CreateRandomPos();
        this.GetDistance();
    }

    protected override void GetComponent()
    {
        this.GetComponentPlayer();
    }

    protected virtual void CreateRandomPos()
    {
        transform.position = new Vector3(this.x, this.y, this.z);
    }

    protected virtual void RandomXY()
    {
        this.RandomX();
        this.RandomZ();
    }

    protected virtual void RandomX()
    {
        this.x = Random.Range(-50f, 44f);
    }
    protected virtual void RandomZ()
    {
        this.z = Random.Range(-37f, 59f);
    }

    protected virtual void GetComponentPlayer()
    {
        this.player = GameObject.Find("Player").GetComponent<Transform>();
    }

    protected virtual void GetDistance()
    {
        this.distanceToPlayer = Vector3.Distance(transform.position, this.player.position);
    }

}
