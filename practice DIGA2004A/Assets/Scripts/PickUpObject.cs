using UnityEngine;

public class PickUpObject : MonoBehaviour
{
    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void Awake()
    {
        rb = GetComponent<Rigidbody>();

    }

    public void PickUp(Transform holdPoint)
    {
          rb.useGravity = false; // Disable gravity
          rb.linearVelocity =Vector3.zero;
          rb.angularVelocity = Vector3.zero;

          transform.SetParent(holdPoint);
          transform.localPosition = Vector3.zero;

    }

    public void Drop()
    {
        rb.useGravity = true; // use gravity when dropping the object
        transform .SetParent(null); // Remove the parent to drop the object
    }

    public void Throw(Vector3 impulse)
    {
        transform.SetParent(null); // Remove the parent to throw the object
        rb.useGravity = true; // Enable gravity when throwing
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        rb.AddForce(impulse, ForceMode.Impulse); // Apply force to the object in the forward direction
    }

    public void MoveToHoldPoint(Vector3 targetPosition)
    {
        rb.MovePosition(targetPosition); // Move the object to the target position
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
