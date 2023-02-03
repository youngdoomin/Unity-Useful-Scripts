using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ColorExtensions
{
   public static Color GetRandomColor()
    {
        float r = UnityEngine.Random.Range(0f, 1f);
        float g = UnityEngine.Random.Range(0f, 1f);
        float b = UnityEngine.Random.Range(0f, 1f);
        return new Color(r, g, b);
    }
}
