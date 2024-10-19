using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NearbyTargetItem2D : MMonoBehaviour
{

    protected float x = default;
    protected float y = default;
    protected float z = 0;
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
        this.RandomY();
    }

    protected virtual void RandomX()
    {
        this.x = Random.Range(-16f, 17f);
    }
    protected virtual void RandomY()
    {
        this.y = Random.Range(-9f, 10f);
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
