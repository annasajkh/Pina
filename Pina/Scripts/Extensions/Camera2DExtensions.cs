﻿using Raylib_cs;
using System.Numerics;

namespace Pina.Scripts.Extensions;

public static class Camera2DExtensions
{
    /// <summary>
    /// Get the transform matrix (view matrix)
    /// </summary>
    public static Matrix4x4 GetMatrix2D(this ref Camera2D camera)
    {
        return Raylib.GetCameraMatrix2D(camera);
    }
}