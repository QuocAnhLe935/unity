using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerAnimation : MonoBehaviour
{
    public float targetDistance;
    public float maxDistance = 1.5f;
    public Transform Maice;
    public float Damage;
    RaycastHit hit;

    Animation anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animation>();
    }

    void OnTriggerEnter(Collider other)
    {

        //Your function for the health
        float playerHealth = -1.0f;
    }

    void OnTriggerExit(Collider other)
    {
        //Do nothing
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position,
             transform.TransformDirection(Vector3.forward), out hit))
        {
            targetDistance = hit.distance;
            if (targetDistance < maxDistance)
            {
                anim.Play("<your weapon animation name>");
                hit.transform.SendMessage("ApplyDamage", Damage,
                    SendMessageOptions.DontRequireReceiver);
            }
        }
    }
}
