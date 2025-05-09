using UnityEngine;

public class CarController : MonoBehaviour
{
    public float acceleration = 500f;
    public float maxSpeed = 50f;
    public float turnSpeed = 50f;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveInput = Input.GetAxis("Vertical"); // W/S or Up/Down
        float turnInput = Input.GetAxis("Horizontal"); // A/D or Left/Right

        // Forward movement
        if (rb.linearVelocity.magnitude < maxSpeed)
        {
            rb.AddForce(transform.forward * moveInput * acceleration * Time.deltaTime, ForceMode.Acceleration);
        }

        // Turning
        transform.Rotate(Vector3.up, turnInput * turnSpeed * Time.deltaTime);
    }
}