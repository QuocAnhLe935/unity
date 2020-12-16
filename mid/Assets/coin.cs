using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public int rotatespeed;
    public AudioClip coinSound;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotatespeed, 0, Space.World);  
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<PlayerStatus>().points++;
            AudioSource.PlayClipAtPoint(coinSound, transform.position);
            Destroy(gameObject);
        }
    }
}
