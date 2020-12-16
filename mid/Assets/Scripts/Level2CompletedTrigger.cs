using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2CompletedTrigger : MonoBehaviour
{

    void OnTriggerEnter(Collider ChangeScene) // this is when the player reached at the end of the level
    {
        if (ChangeScene.gameObject.CompareTag("Player"))
        {
            Application.LoadLevel(6); //We want Scene 6 since it will tell you that you have completed the 2nd level
        }
    }
}
