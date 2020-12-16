using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  //  private static GameManager instance;
   public float restartDelay = 2f;
    public GameObject completestageUI;
    public int mTime = 20;
    //Show level complete UI
    


    


   public void CompleteStage()
    {
        //Enable level UI
         completestageUI.SetActive(true);
        Debug.Log("hi from game manager");
    }

    //public static GameManager Instance
    //{
    //    get
    //    {
    //        if (instance == null)
    //        {
    //            instance = new GameManager();
    //        }

    //        return instance;
    //    }
    //}

    bool gameEnded = false;
    public void EndGame()
    {
        gameEnded = true;
        Debug.Log("game over");
        Invoke("Restart", restartDelay);
    }
     void Restart()
    {
        //   load scene                    return name of current scene     
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
 

    void Update()
    {
        // Pause game

        bool CanPause = true;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (CanPause)
            {
                Debug.Log("pause");
                Time.timeScale = 0;
                CanPause = false;
            }
            else
            {
                Time.timeScale = 1;
                CanPause = true;
            }
        }
    }
}