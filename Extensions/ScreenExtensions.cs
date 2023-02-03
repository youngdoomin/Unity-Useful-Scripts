using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ScreenExtensions
{
    public static Vector2 GetScreenSizeInPixels()
    {
        return new Vector2(Screen.width, Screen.height);
    }
}
