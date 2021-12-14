using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    [SerializeField] private GameObject[] _tilePref;
    [SerializeField] private GameObject _spawnPref,_corePref;
    [SerializeField] private TileInitializator _tileInitializator;
    private bool _spawnIsCreate = false, 
                 _coreIsCreate = false;

    public GameObject[,] CreateTile(int width,int length)
    {
        GameObject[,] tile = new GameObject[width,length];
        for(int i = 0; i < width; i++)
        {
            for(int j = 0 ; j < length; j++)
            {
                int random = 0;
                if (i==0 || i == width - 1)
                {
                    random = Random.Range(0, width+2);
                }
                if ((i==0 && !_spawnIsCreate) && (random > width - 1 || j == length - 1)) 
                {
                    tile[i,j] = Instantiate(_spawnPref);
                    _spawnIsCreate = true;
                }
                else if ((i == width-1 && !_coreIsCreate) && (random > width - 1 || j == length - 1))
                {
                    tile[i, j] = Instantiate(_corePref);
                    _coreIsCreate = true;
                }
                else
                {
                    tile[i, j] = Instantiate(_tilePref[Random.Range(0,_tilePref.Length)]);
                }
                tile[i, j].transform.position = new Vector3(i * 4, 0, j * 4);
                tile[i, j].name = $"X {i * 4} | Z {j * 4}";
                _tileInitializator.InitializeTile(tile[i,j]);

            }
        }
        return tile;
    }
}
