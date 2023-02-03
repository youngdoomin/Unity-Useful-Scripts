using System.Collections.Generic;
using UnityEngine;

namespace UnityExtensions
{
    /// <summary>
    /// Extension methods for UnityEngine.Vector3.
    /// </summary>
    public static class Vector3Extensions
    {
        /// <summary>
        /// Finds the position closest to the given one.
        /// </summary>
        /// <param name="position">World position.</param>
        /// <param name="otherPositions">Other world positions.</param>
        /// <returns>Closest position.</returns>
        public static Vector3 GetClosest(this Vector3 position, IEnumerable<Vector3> otherPositions)
        {
            var closest = Vector3.zero;
            var shortestDistance = Mathf.Infinity;

            foreach (var otherPosition in otherPositions)
            {
                var distance = (position - otherPosition).sqrMagnitude;

                if (distance < shortestDistance)
                {
                    closest = otherPosition;
                    shortestDistance = distance;
                }
            }

            return closest;
        }

     public static Vector3 ClampMagnitude(this Vector3 vector, float maxLength)
    {
        if (vector.sqrMagnitude > maxLength * maxLength)
        {
            return vector.normalized * maxLength;
        }
        return vector;
    }

         public static Vector3 GetRandomVector3(float min, float max)
    {
        float x = UnityEngine.Random.Range(min, max);
        float y = UnityEngine.Random.Range(min, max);
        float z = UnityEngine.Random.Range(min, max);
        return new Vector3(x, y, z);
    }

    public static bool IsWithinDistance(this Vector3 vector, Vector3 other, float distance)
    {
        return Vector3.Distance(vector, other) <= distance;
    }

     public static string ToString(this Vector3 vector)
    {
        return "(" + vector.x + ", " + vector.y + ", " + vector.z + ")";
    }

public static Vector3 SetX(this Vector3 vector, float x)
    {
        return new Vector3(x, vector.y, vector.z);
    }
    }
}
