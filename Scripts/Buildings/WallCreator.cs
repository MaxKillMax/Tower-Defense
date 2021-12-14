using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCreator : MonoBehaviour
{
    [SerializeField] private GameObject[] _wallPref;
    [SerializeField] private NavMeshRebaker _navMeshRebaker;
    private Transform _tile;

    public void Initialize(Transform tile)
    {
        _tile = tile;
    }
    public void WallCreate()
    {
        GameObject wall;
        wall = Instantiate(_wallPref[0],new Vector3(_tile.position.x, _tile.position.y+0.9f, _tile.position.z),Quaternion.Euler(0,0,0));
        wall.transform.SetParent(_tile,true);
        _navMeshRebaker.Bake();
    }
}
