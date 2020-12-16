using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver1Trigger : MonoBehaviour
{

    void OnTriggerEnter(Collider ChangeScene) // this is when the player reached at the end of the level
    {
        if (ChangeScene.gameObject.CompareTag("Player"))
        {
            Application.LoadLevel(2); //We want Scene 2 since it will tell you that it's game over
        }
    }
}
