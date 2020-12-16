using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    GameObject gameController;
    GameManager gameManager;

    public static GameController instance { get; private set; }

    void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController");
        gameManager = gameController.GetComponent<GameManager>();
    }

    // Use this for initialization
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
