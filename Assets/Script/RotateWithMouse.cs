using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWithMouse : MonoBehaviour
{
    public float rotateSpeed = 5f;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            float mouseX = Input.GetAxis("Mouse X") * rotateSpeed;

            transform.Rotate(Vector3.up, mouseX, Space.World);

         }
        
    }
}
