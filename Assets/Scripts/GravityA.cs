using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class GravityA : MonoBehaviour
{

    Rigidbody rb;
    const float G = 0.06674f;

    public static List<GravityA> gravityObjectList;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

        if (gravityObjectList == null)
        {
            gravityObjectList = new List<GravityA>();
        }

        gravityObjectList.Add(this);
    }


    private void FixedUpdate()
    {
        foreach (GravityA obj in gravityObjectList)
        {
            if(obj != this)
            {
                Attract(obj);
            }

        }


    }
    void Attract(GravityA other)
    {
        Rigidbody rbOther = other.rb;

        Vector3 direction = rb.position - rbOther.position;

        float distance = direction.magnitude;

        if (distance == 0) { return; }

        float forcemagnitude = G * ((rb.mass * rbOther.mass) / Mathf.Pow(distance, 2));
        Vector3 force = forcemagnitude * direction.normalized;
        rbOther.AddForce(force);
        

    }

}

    
