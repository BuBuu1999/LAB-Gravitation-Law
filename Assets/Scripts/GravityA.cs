using UnityEngine;

public class GravityA : MonoBehaviour
{

    Rigidbody rb;
    const float G = 0.00674f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Attract(GravityA other)
    {
        Rigidbody rbOther = GetComponent<Rigidbody>();

        Vector3 direction = rb.position - rbOther.position;

        float distance = direction.magnitude;

        if (distance == 0) { return; }

        float forcemagnitude = G * ((rb.mass * other.rb.mass) / Mathf.Pow(distance, 2));
        Vector3 force = forcemagnitude * direction.normalized;
    }

}
