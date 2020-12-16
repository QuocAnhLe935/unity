using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class hammer : MonoBehaviour
{
    public Rigidbody rb;
    protected float Speed =5.0f;
    public void Start()
    {
        
    }
    public void Update()
    {
        transform.Rotate(5, 0, 0);
        
    }

}
