using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDelete : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
    }

    public float maxLifetime = 3f;

    void Update()
    {
        maxLifetime -= Time.deltaTime;

        if (maxLifetime <= 0)
        {
            Destroy(gameObject);
        }
    }
}
