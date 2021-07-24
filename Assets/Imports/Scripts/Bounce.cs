using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Simple script to bounce an object continuously when it hit the ground.
/// Author: Alben Trang
/// </summary>
public class Bounce : MonoBehaviour
{
    public float upwardForce = 10.0f;

    /// <summary>
    /// Send the object up by using force.
    /// </summary>
    /// <param name="collision">The other object it hits.</param>
    private void OnCollisionEnter(Collision collision)
    {
        this.GetComponent<Rigidbody>().AddForce(new Vector3(0, upwardForce, 0));
    }
}
