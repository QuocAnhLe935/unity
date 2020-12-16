using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup : MonoBehaviour
{
    public float mulitplier = 1.8f;
    private float rotatespeed = 1;
    private float watiduration = 4.0f;
    CountD count;

    public AudioClip powerUpSound;

    void Update()
    {
        transform.Rotate(0, rotatespeed, 0, Space.World);

        count = FindObjectOfType<CountD>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")){
           StartCoroutine( Pickup(other));
            count.currentTime += 10.0f;
        }
    }


    IEnumerator Pickup(Collider player)
    {
        AudioSource.PlayClipAtPoint(powerUpSound, transform.position);
        player.transform.localScale *= mulitplier;
        PlayerStatus stats= player.GetComponent<PlayerStatus>();
        stats.currentHealth += 20;
        stats.healthBAR.SetHealth(stats.currentHealth);

        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

        
       

        

        //wait x sec
        yield return new WaitForSeconds(watiduration);
        //reverse the effect
        player.transform.localScale /= mulitplier;


       

        //destroy the item
        Destroy(gameObject);



       
    }
}
