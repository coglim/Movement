using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletUseScript : MonoBehaviour
{
    public Transform gun;
    public GameObject bullet;

    public float bulletSpeed;

    void Update()
    {
        if (Input.GetMouseButtonDown (0))
        {
            GameObject newBullet = Instantiate(bullet, gun.position, gun.rotation);
            newBullet.GetComponent<Rigidbody>().AddForce(gun.right * bulletSpeed, ForceMode.Impulse);
        }
    }
}
