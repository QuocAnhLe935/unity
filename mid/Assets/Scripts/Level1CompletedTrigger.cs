using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1CompletedTrigger : MonoBehaviour
{

    void OnTriggerEnter(Collider ChangeScene) // this is when the player reached at the end of the level
    {
        if (ChangeScene.gameObject.CompareTag("Player"))
        {
            Application.LoadLevel(3); //We want Scene 2 since it will tell you that you have completed the 1st level
        }
    }
}
