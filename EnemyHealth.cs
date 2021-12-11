using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 100;
    int currentHealth;
    private bool dead = false;
    public bool Dead { get { return dead; }}

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("Hurt.");

        if(currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Enemy died.");
        GetComponent<Animator>().SetTrigger("Die");
        GetComponent<NavMeshAgent>().SetDestination(transform.position);
        GetComponent<EnemyAI>().target = null;
        dead = true;
    }


}

