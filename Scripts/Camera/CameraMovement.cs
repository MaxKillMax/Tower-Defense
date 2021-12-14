using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform _transform;

    public void Move(Vector3 direction)
    {
        _transform.position += direction * Time.deltaTime * 10;
    }

    public void CheckHeight()
    {
        Vector3 location = _transform.position;
        if (location.y > 15)
        {
            _transform.rotation = Quaternion.Euler(location.y * 4, 0, 0);
            if (location.y > 22)
            {
                _transform.position = new Vector3(location.x, 22.01f, location.z);
                _transform.rotation = Quaternion.Euler(90, 0, 0);
            }
        }
        else
        {
            if (location.y < 2)
            {
                _transform.position = new Vector3(location.x, 2.01f, location.z);
            }
        }
        
    }
}
