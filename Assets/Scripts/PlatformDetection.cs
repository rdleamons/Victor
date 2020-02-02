using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDetection : MonoBehaviour
{
    public bool isTrigger = true;
    void OnColliderEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Feet"))
        {
            isTrigger = false;
        }

    }
}
