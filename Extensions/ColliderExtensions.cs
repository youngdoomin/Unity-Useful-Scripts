using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ColliderExtensions
{
     public static bool IsTouching(this Collider collider, Collider other)
    {
        return collider.bounds.Intersects(other.bounds);
    }
}
