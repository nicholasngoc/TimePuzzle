using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Simple script to rotate an object continuously.
/// Author: Alben Trang
/// </summary>
public class Rotate : MonoBehaviour
{
    /// <summary>
    /// Rotate the object at a certain angle.
    /// </summary>
    void FixedUpdate()
    {
        this.gameObject.transform.Rotate(new Vector3(0.5f, 1.0f, 1.5f));
    }
}
