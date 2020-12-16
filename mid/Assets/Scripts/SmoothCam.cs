using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCam : MonoBehaviour
{
    public Transform target;
    private Vector3 offset;
    [Range(0.01f, 1.0f)]
    public float smoothSpeed = 0.5f;
   

     void Start()
    {
        offset = transform.position - target.position; 
    }
     void Update()
    {
        Vector3 newPos = target.position + offset;
        transform.position = Vector3.Slerp(transform.position, newPos, smoothSpeed);
    }
}
