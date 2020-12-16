using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver2Trigger : MonoBehaviour
{
    void OnTriggerEnter(Collider ChangeScene) // this is when the player reached at the end of the level
    {
        if (ChangeScene.gameObject.CompareTag("Player"))
        {
            Application.LoadLevel(5); //We want Scene 5 since it will tell you that it's game over
        }
    }
}
