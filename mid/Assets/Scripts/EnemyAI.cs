using System.Collections;
using System.Collections.Generic;
using System.Runtime;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    //This exposes the target in the inpector so you can choose who the ai is targeting
    [SerializeField] Transform target;
    //This exposes to the inspector how close you have to be for the Ai to chase you
    [SerializeField] float chaseRange = 5f;
    //This is bringing the mesh that overlays the game into code so you can mess with it. The navmesh is a built in component to unity
    //You can find it by going into components->navigation.
    NavMeshAgent navMeshAgent;
    
    //this detect the distance between two objects
    float distanceToTarget =Mathf.Infinity;
    bool isProvoked = false;

    void Start()
    {
        //one time at the beginning of the game it grabs the component NavMesh agent so it can be used in the scene
        navMeshAgent = GetComponent<NavMeshAgent>();
    }


    void Update()
    {
        //This is how the taget figures out how far you are and makes the AI begin to move towards the player(we did this in math last semester)
        //this needs to update everyframe so it can tell wether or not you are within the proximity of the AI or not.
        distanceToTarget = Vector3.Distance(target.position, transform.position);
        if (isProvoked)
        {
            EngageTarget();
        }
        else if (distanceToTarget <= chaseRange)
        {
            isProvoked = true;
        }

    }

    private void EngageTarget()
    {
        if (distanceToTarget >= navMeshAgent.stoppingDistance)
        {
            ChaseTarget();
        }

        if (distanceToTarget <= navMeshAgent.stoppingDistance)
        {
            AttackTarget();
        }
    }

    private void ChaseTarget()
    {
        GetComponent<Animator>().SetBool("attack", false);
        GetComponent<Animator>().SetTrigger("move");
        navMeshAgent.SetDestination(target.position);
    }

    private void AttackTarget()
    {
        GetComponent<Animator>().SetBool("attack", true);
        Debug.Log(name + " Player Life lost " + target.name);
    }
    void OnDrawGizmosSelected()
    {
        //this give a physical red sphere around the target that shows how far the ai can chase you so you can see it visually.
        // take a look at the AI next time you click on them to see the red wireframe sphere around them.
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, chaseRange);
    }
}
