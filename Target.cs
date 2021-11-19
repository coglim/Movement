using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    void OnCollisionEnter (Collision other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            GameObject.Find("Score").GetComponent<Score>().AddScore();
        
        Debug.Log("Got hit." + gameObject.name);
            Destroy(gameObject);
        }
    }
}
