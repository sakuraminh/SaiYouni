using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Moveinaspiral : MMonoBehaviour
{
    [SerializeField] protected GameObject emptyPrefab;
    [SerializeField] protected float radiusStep = 0.5f;
    [SerializeField] protected float angleStep = 15f;
    [SerializeField] protected int maxSteps = 100;
    [SerializeField] protected float waitTime = 0.5f;

    [SerializeField] protected NavMeshAgent agent;
    [SerializeField] protected List<Transform> spiralPoints;
    [SerializeField] protected int currentPoint = 0;

    [SerializeField] protected Transform hold;

    protected override void Start()
    {
        base.Start();
        this.SetCirclePoints();
    }

    protected override void GetComponent()
    {
        this.GetComponentPrefab();
        this.GetComponentHolf();
        this.GetComponentAgent();
    }

    private void GetComponentAgent()
    {
        agent = GetComponentInParent<NavMeshAgent>();
    }

    private void GetComponentHolf()
    {
        this.hold = GameObject.Find("Hold").GetComponent<Transform>();
    }

    private void GetComponentPrefab()
    {
        this.emptyPrefab = GameObject.Find("PrefabPoint").transform.Find("Point").gameObject;
    }

    private void SetCirclePoints()
    {
        spiralPoints = GenerateSpiralPoints();

        if (spiralPoints.Count > 0)
        {
            MoveToNextPoint();
        }
    }

    protected void Update()
    {
        if (!agent.pathPending && agent.remainingDistance <= agent.stoppingDistance)
        {
            MoveToNextPoint();
        }
    }
    protected void MoveToNextPoint()
    {
        if (currentPoint < spiralPoints.Count)
        {
            agent.SetDestination(spiralPoints[currentPoint].position);

            currentPoint++;
        }
    }
    protected List<Transform> GenerateSpiralPoints()
    {
        List<Transform> points = new List<Transform>();

        float radius = 0f;
        float angle = 0f;

        Vector3 startPosition = transform.position;

        for (int i = 0; i < maxSteps; i++)
        {

            float x = radius * Mathf.Cos(angle * Mathf.Deg2Rad);
            float z = radius * Mathf.Sin(angle * Mathf.Deg2Rad);

            Vector3 newPosition = new Vector3(startPosition.x + x, startPosition.y, startPosition.z + z);

            GameObject emptyObject = Instantiate(emptyPrefab, newPosition, Quaternion.identity);
            emptyObject.name = "SpiralPoint_" + i;

            points.Add(emptyObject.transform);
            emptyObject.transform.parent = this.hold;

            radius += radiusStep;
            angle += angleStep;
        }

        return points;
    }
}
