using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardSpeed = 400f;

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardSpeed * Time.deltaTime);
    }
}
