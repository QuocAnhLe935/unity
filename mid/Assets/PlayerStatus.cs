using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public int points = 0;
    public HealthBAR healthBAR;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBAR.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (currentHealth <= 0)
        {
            Die();
            FindObjectOfType<GameManager>().EndGame();
            Debug.Log("hi from current");

        }
        //if (currentHealth <= 0)
        //{
        //    FindObjectOfType<GameManager>().EndGame();
        //}

    }
    //score
    private void OnGUI()
    {
        GUI.Label(new Rect(100, 150, 1000, 600), "SCORE:" + points);
    }
    void Die()
    {
        Destroy(gameObject);
    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBAR.SetHealth(currentHealth);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "AI")
        {
            TakeDamage(10);
        }

        if (collision.collider.tag == "badBlock")
        {
            TakeDamage(10);
        }
    }
}
