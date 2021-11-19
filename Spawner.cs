using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;

    public int number = 6;

    public float x;

    public float z;

    void Start () 
    {
        int k;
        for (k = 0; k < number; k ++)
        Instantiate (enemy, new Vector3( Random.Range(-x,x), 0, Random.Range(-z,z)), Quaternion.identity);
    } 
}
