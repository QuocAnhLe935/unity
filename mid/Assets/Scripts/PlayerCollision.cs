using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Movement playermovement;
    public PlayerStatus healths;
    //if player touch tag"badBlock" player dies
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "badBlock")
        {

            Debug.Log("bad");
           
        }
    }
}
