using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private Vector3 originalCam;
    private Vector3 originalMouse;
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 delNor = Camera.main.ScreenToViewportPoint(Input.mousePosition) - originalMouse;
            delNor.z = 0;
            Vector3 newPos = transform.position + delNor;
            transform.position = Vector3.Lerp(originalCam, newPos, 0.5f);
        }
        else
        {
            originalCam = transform.position;
            originalMouse = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        }
    }
}
