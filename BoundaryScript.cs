using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryScript : MonoBehaviour
{
    public GameObject obstacle;
    public float xBoundary, zBoundary;
    public int maxEnemies = 10;
    public List<GameObject> blocks;

    void Start()
    {
        for (int i = 0; 1 < 10; i++)
        {
            Instantiate(obstacle, new Vector3(Random.Range(-xBoundary, xBoundary), 4, Random.Range (-zBoundary, zBoundary)), Quaternion.identity);
        }
    }

}
