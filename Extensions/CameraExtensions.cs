using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CameraExtensions
{
   public static Vector2 GetViewportSize(this Camera camera)
    {
        return new Vector2(camera.pixelWidth, camera.pixelHeight);
    }
}
