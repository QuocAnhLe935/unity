using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public GameObject collisionObject;
    float damage = -1f;
    float healing = 1f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "LoseFoodCol")
        {
            Destroy(col.gameObject);
            print("vous avez perdu un coeur");
        }
        if (col.gameObject.tag == "WinFoodCol")
        {
            Destroy(col.gameObject);
            print("vous avez gagné un coeur");
        }
        if (col.gameObject.tag == "LightCol")
        {
            Destroy(col.gameObject);
        }
    }
}