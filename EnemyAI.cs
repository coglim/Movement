using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public Transform target;
    public NavMeshAgent agent;

    public delegate void UpdateScore();
    public static UpdateScore addPoint;
    public EnemyHealth health;

    void Awake() 
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        health = GetComponent<EnemyHealth>();
    }

    void Update()
    {
        if (target != null && !health.Dead)        
        {
            agent.SetDestination(target.position);
            transform.LookAt(target);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Sword")
        {

            Destroy(gameObject);
        }
    }

}