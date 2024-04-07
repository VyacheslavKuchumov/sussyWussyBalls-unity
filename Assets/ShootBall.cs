using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBall : MonoBehaviour
{
    public float forceAmount = 10f;
    private Rigidbody rb;
    private Vector3 lastVelocity; 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        // Check if Rigidbody component exists
        if (rb != null)
        {
            // Apply force in the upward direction
            rb.AddForce(Vector3.up * forceAmount, ForceMode.Impulse);
        }
        else
        {
            Debug.LogWarning("Rigidbody component not found!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        lastVelocity = rb.velocity;
    }

    private void OnCollisionEnter(Collision collision)
    {
        var speed = lastVelocity.magnitude;
        var direction = Vector3.Reflect(lastVelocity.normalized, collision.contacts[0].normal);

        rb.velocity = direction * Mathf.Max(speed, 0f);
    }
}
