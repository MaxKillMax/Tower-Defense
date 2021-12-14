using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private CameraMovement _cameraMovement;
    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        Vector3 direction = new Vector3(horizontal, scroll*-300, vertical);
        _cameraMovement.Move(direction);
        _cameraMovement.CheckHeight();
    }
}
