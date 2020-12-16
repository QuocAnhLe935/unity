using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraswitch : MonoBehaviour
{
    public GameObject CameraOn;
    public GameObject CameraOff;
     void OnTriggerEnter()
    {
        Debug.Log("cross");
       // CameraOn.SetActive(true);
      //  CameraOff.SetActive(false);
    }
}
