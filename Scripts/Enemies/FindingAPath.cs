using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class FindingAPath : MonoBehaviour
{
    private NavMeshAgent _navMeshAgent;
    private GameObject _core;
    private void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _core = new GameObject();
        _core = GameObject.FindGameObjectWithTag("Core");
    }

    private void Update()
    {
        _navMeshAgent.SetDestination(_core.transform.position);
    }

}
