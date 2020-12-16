using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCompletedSound : MonoBehaviour
{
    public AudioSource LevelCompletedSource;

    void Start()
    {
        LevelCompletedSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision) // play music towards the level completion scene
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            LevelCompletedSource.Play();
        }
    }
}
