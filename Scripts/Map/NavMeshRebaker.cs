using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshRebaker : MonoBehaviour
{
    private NavMeshSurface _meshSurface;
    private void Start()
    {
        _meshSurface = GetComponent<NavMeshSurface>();
        Bake();
    }
    public void Bake()
    {
        _meshSurface.BuildNavMesh();
    }
}
