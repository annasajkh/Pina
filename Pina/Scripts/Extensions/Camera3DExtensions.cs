using Raylib_cs;
using System.Numerics;

namespace Pina.Scripts.Extensions;


public static class Camera3DExtensions
{
    /// <summary>
    /// The transform matrix (view matrix)
    /// </summary>
    public static Matrix4x4 GetMatrix(this ref Camera3D camera)
    {
        return Raylib.GetCameraMatrix(camera);
    }
}