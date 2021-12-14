using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    
    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        
        if (horizontal != 0 || vertical != 0)
        {
            Move(horizontal, vertical, scroll);
        }
        
        if (scroll != 0)
        {
            SetHeight(scroll);
        }
    }
    
    private void Move(float horizontal, float vertical, float scroll)
    {
        float scrollMultiply = -300;
        float speed = 10;
    
        Vector3 direction = new Vector3(horizontal, scroll * scrollMultiply, vertical);
        transform.position += direction * Time.deltaTime * speed;
    }

    private void SetHeight(float scrollValue)
    {
        float scrollMultiply = 4;
        float cameraMinRotateY = 15
    
        float cameraMaxY = 22;
        float cameraMinY = 2;
    
        if (transform.position.y > minRotateValueY)
        {
            transform.rotation = Quaternion.Euler(transform.position.y * scrollValue * scrollMultiply, 0, 0);
            
            if (transform.position.y >= cameraMaxY)
            {
                transform.position = new Vector3(transform.position.x, cameraMaxY, transform.position.z);
                transform.rotation = Quaternion.Euler(90, 0, 0);
            }
        }
        else
        {
            if (transform.position.y <= cameraMinY)
            {
                transform.position = new Vector3(transform.position.x, cameraMinY, transform.position.z);
            }
        }
        
    }
}
