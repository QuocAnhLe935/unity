using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOverSound : MonoBehaviour
{
    public AudioSource gameOverSource;

    void Start()
    {
        gameOverSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider collision) // play music towards the game over scene
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameOverSource.Play();
        }
    }
}
