using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    [SerializeField] private MapGenerator _mapGenerator;
    [SerializeField] private int _length;
    [SerializeField] private int _width;
    private GameObject[,] _tiles , _walls;
    private void Awake()
    {
        _tiles = new GameObject[_width, _length];
        _tiles = _mapGenerator.CreateTile(_width, _length);
    }
}
