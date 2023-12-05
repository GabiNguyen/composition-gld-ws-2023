using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObject : MonoBehaviour
{
    public Rigidbody[] rbs;

    public void OnTriggerEnter(Collider other)
    {
        foreach (var rb in rbs) {
            rb.constraints = RigidbodyConstraints.None;
        }
    }
}
