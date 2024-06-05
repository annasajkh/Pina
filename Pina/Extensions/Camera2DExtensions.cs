using Raylib_cs;
using System.Numerics;

namespace Pina.Extensions;

public static class Camera2DExtensions
{
    /// <summary>
    /// Get the transform matrix (view matrix)
    /// </summary>
    public static Matrix4x4 GetMatrix2D(this Camera2D camera)
    {
        return Raylib.GetCameraMatrix2D(camera);
    }
}
