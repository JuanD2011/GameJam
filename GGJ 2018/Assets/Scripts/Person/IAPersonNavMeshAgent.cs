using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IAPersonNavMeshAgent : MonoBehaviour {

    [SerializeField]

    NavMeshAgent _navmesh;
    [SerializeField]
    public Transform[] waypoint;
    [SerializeField]
    private int currentPoint = 0;

    void start()
    {
        _navmesh = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        if (currentPoint == waypoint.Length - 1)
        {
            currentPoint = 0;
        }
        if (transform.position.x == waypoint[currentPoint].position.x)
        {
            currentPoint++;
        }
        SetDestination();
    }
    void SetDestination()
    {
        if (waypoint[currentPoint] != null)
        {
            _navmesh.SetDestination(waypoint[currentPoint].position);
   
        }
    }
    /*
    void IAPatrol()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, waypoint[currentPoint].position, step);
        if (currentPoint == waypoint.Length - 1)
        {
            currentPoint = 0;
        }
        if (transform.position == waypoint[currentPoint].position)
        {
            StartCoroutine(rotacion());
            //transform.forward = waypoint[currentPoint].position;
            currentPoint++;
        }
  */
}
