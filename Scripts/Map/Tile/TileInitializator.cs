using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileInitializator : MonoBehaviour
{
    [SerializeField] private Color _colorOnSelect;
    [SerializeField] private GameObject _panel;
    [SerializeField] private WallCreator _wallCreator;

    public void InitializeTile(GameObject tile)
    {
        tile.transform.GetChild(0).gameObject.AddComponent<OnSelectable>().Initialize(_colorOnSelect, _panel,_wallCreator);
    }
}
