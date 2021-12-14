using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TileSelector : MonoBehaviour
{
    private OnSelectable _currentSelectable;
    private Camera _camera;

    private void Start()
    {
        _camera = Camera.main;
    }

    private void Update()
    { 
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Physics.Raycast(ray,out hit) && !EventSystem.current.IsPointerOverGameObject())
        {
            if (Input.GetMouseButtonDown(0))
            {
                OnSelectable selectable = hit.collider.gameObject.GetComponent<OnSelectable>();
                if (selectable)
                {
                    if (_currentSelectable && _currentSelectable != selectable)
                    {
                        _currentSelectable.Deselect();
                    }
                    _currentSelectable = selectable;
                    selectable.Select();
                }
                else if(_currentSelectable)
                {
                    _currentSelectable.Deselect();
                    _currentSelectable = null;
                }
            }
            else if (Input.GetMouseButtonDown(1) && _currentSelectable)
            {
                _currentSelectable.Deselect();
            }
        }
    }
}
