using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnSelectable : MonoBehaviour
{
    private Renderer _renderer;
    private Color _color;
    private GameObject _panel;
    private WallCreator _wallCreator;
    private void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    public void Initialize(Color color,GameObject panel, WallCreator wallCreator)
    {
        _color = color;
        _panel = panel;
        _wallCreator = wallCreator;
    }
    public void Select()
    {
        _renderer.material.color = _color;
        if (!_panel.activeSelf) {
            _panel.SetActive(true);
        }
        _wallCreator.Initialize(transform);
        
    }

    public void Deselect()
    {
        _renderer.material.color = Color.white;
        if (_panel.activeSelf)
        {
            _panel.SetActive(false);
        }
    }

}
