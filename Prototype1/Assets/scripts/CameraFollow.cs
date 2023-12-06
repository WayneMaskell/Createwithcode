using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform vehicle;//holds a ref to our vehicle.
    private Vector3 offset;//maintains a distance between camera and vehicle.
    public float smoothSpeed = 0.1f;
    
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - vehicle.position; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void LateUpdate()
    {
        MoveCameraWithLerp();
    }
    private void MoveCameraWithoutLerp() //basic camera movement
    {
        transform.position = vehicle.position + offset;
    }

    private void MoveCameraWithLerp()//smoother camera movement
    {
        Vector3 expectedPosition = vehicle.position + offset;

        Vector3 smoothPosition = Vector3.Lerp(transform.position, expectedPosition, smoothSpeed);

        transform.position = smoothPosition;

        transform.LookAt(vehicle);
    
    
   
    }
}
