using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveInACircle : MMonoBehaviour
{
    [SerializeField] protected GameObject emptyPrefab;
    [SerializeField] protected float radius = 5f;
    [SerializeField] protected int numberOfPoints = 36;
    [SerializeField] protected float waitTime = 0f;

    [SerializeField] protected NavMeshAgent agent;
    [SerializeField] protected List<Transform> circlePoints;
    [SerializeField] protected int currentPoint = 0;

    [SerializeField] Transform hold;

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
        hold = GameObject.Find("Hold").GetComponent<Transform>();
    }

    private void GetComponentPrefab()
    {
        this.emptyPrefab = GameObject.Find("PrefabPoint").transform.Find("Point").gameObject;
    }

    protected virtual void SetCirclePoints()
    {
        circlePoints = GenerateCirclePoints();
        if (circlePoints.Count > 0)
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
        if (currentPoint < circlePoints.Count)
        {
            agent.SetDestination(circlePoints[currentPoint].position);
            currentPoint = (currentPoint + 1) % circlePoints.Count;
        }
    }
    protected List<Transform> GenerateCirclePoints()
    {
        List<Transform> points = new List<Transform>();

        Vector3 centerPosition = transform.position;

        for (int i = 0; i < numberOfPoints; i++)
        {
            float angle = i * (360f / numberOfPoints);
            float angleRad = Mathf.Deg2Rad * angle;

            float x = centerPosition.x + radius * Mathf.Cos(angleRad);
            float z = centerPosition.z + radius * Mathf.Sin(angleRad);

            Vector3 newPosition = new Vector3(x, centerPosition.y, z);
            GameObject emptyObject = Instantiate(emptyPrefab, newPosition, Quaternion.identity);

            emptyObject.transform.parent = this.hold;
            emptyObject.name = "CirclePoint_" + i;

            points.Add(emptyObject.transform);
        }
        return points;
    }
}
