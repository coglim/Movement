using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public int maxHealth;
    int currentHealth;
    NavMeshAgent agent;
    Animator animator;
    Transform player;
    public GameObject deathEffect;
    bool attacking;
    public float attackDelay;


    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();

        currentHealth = maxHealth;

        player = GameObject.Find("Player").transform;
    }

    void Update()
    {
         if (player != null) 
        {
            agent.SetDestination(player.position);
            if (!attacking && Vector3.Distance(transform.position, player.position) < 2) 
            {
                Attack();
            }    
        }


    }
    
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("Current health: " + currentHealth);

        if (currentHealth <= 0) Die();
    }

    public void Die()
    {
        if (deathEffect != null) Instantiate(deathEffect, transform.position, Quaternion.identity);
        Debug.Log("Enemy has died.");
        Destroy (gameObject);
    }

    void Attack()
    {
        attacking = true;
        animator.SetTrigger("Attack");
        if (Physics.Raycast(transform.position, transform.forward, 1.5f, 1<<9))
        {
            player?.gameObject.GetComponent<Player>().TakeDamage(20);
        }
        
        Invoke("ResetAttack", attackDelay);
    }

    void ResetAttack()
    {
        attacking = false;
    }
}
