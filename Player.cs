using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator animator;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    public int attackDamage = 40; 
    public int maxHealth;
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }        
    }

    void Attack()
    {
        animator.SetTrigger("Attack");
         if (Physics.Raycast(transform.position, transform.forward, 1f))
    {
        GameObject.Find("Spartan_Warrior").GetComponent<Enemy>().TakeDamage(25);
    }

    }

    void OnTriggerEnter(Collider other)
    {
        var hitTarget = other.GetComponent<Enemy>();
        hitTarget?.TakeDamage(20);
    }

    void OnDrawGizmosSelected()
    {
        if(attackPoint == null)
            return;

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Destroy (gameObject);
        }
    }
}
