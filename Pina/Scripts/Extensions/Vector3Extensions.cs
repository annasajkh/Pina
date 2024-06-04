using Raylib_cs;
using System.Numerics;

namespace Pina.Scripts.Extensions;

public static class Vector3Extensions
{
    /// <summary>
    /// Calculate one vector perpendicular vector
    /// </summary>
    public static Vector3 Perpendicular(this Vector3 value)
    {
        return Raymath.Vector3Perpendicular(value);
    }

    /// <summary>
    /// Calculate angle between two vectors
    /// </summary>
    public static Vector2 Angle(this Vector3 value, Vector3 target)
    {
        return Raymath.Vector3Angle(value, target);
    }

    /// <summary>
    /// Transform a vector by quaternion rotation
    /// </summary>
    public static Vector3 RotateByQuaternion(this Vector3 value, Quaternion quaternion)
    {
        return Raymath.Vector3RotateByQuaternion(value, quaternion);
    }

    /// <summary>
    /// Rotates a vector around an axis
    /// </summary>
    public static Vector3 RotateByAxisAngle(this Vector3 value, Vector3 axis, float angle)
    {
        return Raymath.Vector3RotateByAxisAngle(value, axis, angle);
    }

    /// <summary>
    /// Compute barycenter coordinates (u, v, w) for point p with respect to triangle (a, b, c) NOTE: Assumes P is on the plane of the triangle
    /// </summary>
    public static Vector3 Barycenter(this Vector3 value, Vector3 a, Vector3 b, Vector3 c)
    {
        return Raymath.Vector3Barycenter(value, a, b, c);
    }

    /// <summary>
    /// Projects a Vector3 from screen space into object space
    /// </summary>
    public static Vector3 Unproject(this Vector3 value, Matrix4x4 projection, Matrix4x4 view)
    {
        return Raymath.Vector3Unproject(value, projection, view);
    }

    /// <summary>
    /// Get Vector3 as float array
    /// </summary>
    public static Float3 ToFloatV(this Vector3 value)
    {
        return Raymath.Vector3ToFloatV(value);
    }

    /// <summary>
    /// Invert the given vector
    /// </summary>
    public static Vector3 Invert(this Vector3 value)
    {
        return Raymath.Vector3Invert(value);
    }

    /// <summary>
    /// Clamp the magnitude of the vector between two values
    /// </summary>
    public static Vector3 ClampValue(this Vector3 value, float min, float max)
    {
        return Raymath.Vector3ClampValue(value, min, max);
    }

    /// <summary>
    /// Compute the direction of a refracted ray where v specifies the normalized direction of the incoming ray, n specifies the normalized normal vector of the interface of two optical media, and r specifies the ratio of the refractive index of the medium from where the ray comes to the refractive index of the medium on the other side of the surface
    /// </summary>
    public static Vector3 Refract(this Vector3 value, Vector3 n, float r)
    {
        return Raymath.Vector3Refract(value, n, r);
    }
}
