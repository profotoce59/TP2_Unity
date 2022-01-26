using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollow : MonoBehaviour
{
    private float rotX = -45;

    private float rotY = 0;
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(rotX, rotY, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.mousePosition.y <= Screen.height)
        {
            rotX -= Input.GetAxis("Mouse Y") * 5;
            rotY += Input.GetAxis("Mouse X") * 5;
            transform.rotation = Quaternion.Euler(rotX, rotY, 0);
        }
    }
}
