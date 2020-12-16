using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountD : MonoBehaviour
{
   public float currentTime= 0.0f;
   public float startingTime=30.0f;
    //countdowntext
    public Text countdowntext;//[SerializeField]
    void Start()
    {
        currentTime = startingTime;
    }
    void Update()
    {
        //decrease each second not frame
        currentTime -= 1 * Time.deltaTime;
        //get text component
        countdowntext.text = currentTime.ToString();





        // If the current time is below 0, then you failed
        if (currentTime <= 0.2f)
        {
            Application.LoadLevel(2); // Load Game Over Screen for Level 1
        }
    }

   


}
