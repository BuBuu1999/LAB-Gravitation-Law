using UnityEngine;

public class GravityA : MonoBehaviour
{

    Rigidbody rb;
    const float G = 0.00674f;

    private void awake()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Attract(GravityA other)
    {
        Rigidbody rbother = GetComponent<Rigidbody>(); ;
    }

}
