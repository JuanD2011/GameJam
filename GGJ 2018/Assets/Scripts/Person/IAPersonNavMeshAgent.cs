using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IAPersonNavMeshAgent : MonoBehaviour {

    AudioSource wShout;

    [SerializeField]
    NavMeshAgent _navmesh;
    [SerializeField]
    public Transform[] waypoint;
    [SerializeField]
    private int currentPoint = 0;
    GameObject player;

    [SerializeField]
    public bool isIn;
    float buffTime = 5f;
    public float initialSpeed = 3.5f;
    float buffSpeed = 6f;

    void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Player");
        _navmesh = GetComponent<NavMeshAgent>();
        initialSpeed = _navmesh.speed;
        wShout = GetComponent<AudioSource>();
    }
    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");
      
        
    }
	void FixedUpdate(){
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
        if(isIn == false )
        {
            if (waypoint[currentPoint] != null)
            {
                _navmesh.SetDestination(waypoint[currentPoint].position);
            }
        }
        else
        {
			if (player != null )
            {
                _navmesh.SetDestination(player.transform.position);
                _navmesh.speed = buffSpeed;
                Invoke("nerf", buffTime);
            }            
        }
    }
    
    void nerf()
    {
        _navmesh.speed = initialSpeed;
        isIn = false;
    }
	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player" && !other.gameObject.GetComponent<Rat>().invisibilitybool)
		{
            wShout.Play();
            isIn = true;
            
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
