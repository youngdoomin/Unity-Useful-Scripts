using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Vector2Extensions
{
    public static float AngleBetween(this Vector2 vectorA, Vector2 vectorB)
    {
        float angle = Vector2.Angle(vectorA, vectorB);
        float sign = Mathf.Sign(Vector3.Cross(vectorA, vectorB).z);
        return angle * sign;
    }
}
