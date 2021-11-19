using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [Range(0f, 100f)]
    public float speed = 3;

    public Camera cam;

    public Rigidbody rb;
    public float jumpForce;

    bool grounded = false;

    void Update()
    {
        // this is where pick up the player input
        Vector2 playerInput;
        playerInput.x = Input.GetAxis("Horizontal");
        playerInput.y = Input.GetAxis("Vertical");

        // this is where we use the player input
        Vector3 velocity = new Vector3(playerInput.x, 0f, playerInput.y) * speed;
        // adjust velocity for framerate
        Vector3 displacement = velocity * Time.deltaTime;

        // adjust position with displacement
        transform.position += displacement;

        // aiming 
        Vector3 mousePos = Input.mousePosition;  // take in the mouse position
        Vector3 playerPos = cam.WorldToScreenPoint(transform.position);  // convert the current position

        Vector3 lookDir = mousePos - playerPos;  // direction to look in

        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.AngleAxis(-angle, Vector3.up);

        // jumping script

        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            grounded = false;
            rb.AddForce(jumpForce * Vector3.up, ForceMode.Impulse);
        }
    }

    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "Ground") grounded = true;
    }
}
