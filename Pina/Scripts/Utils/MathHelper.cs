using Raylib_cs;
using System.Numerics;

namespace Pina.Scripts.Utils;


public static class MathHelper
{
    /// <summary>
    /// Clamp float value within a specified range
    /// </summary>
    /// <param name="value">Value to clamp</param>
    /// <param name="min">Minimum value</param>
    /// <param name="max">Maximum value</param>
    /// <returns>The clamped value</returns>
    public static float Clamp(float value, float min, float max)
    {
        return Raymath.Clamp(value, min, max);
    }

    /// <summary>
    /// Calculate linear interpolation between two floats
    /// </summary>
    /// <param name="start">Start value</param>
    /// <param name="end">End value</param>
    /// <param name="amount">Interpolation amount</param>
    /// <returns>The interpolated value</returns>
    public static float Lerp(float start, float end, float amount)
    {
        return Raymath.Lerp(start, end, amount);
    }

    /// <summary>
    /// Normalize input value within input range
    /// </summary>
    /// <param name="value">Value to normalize</param>
    /// <param name="start">Start of the input range</param>
    /// <param name="end">End of the input range</param>
    /// <returns>The normalized value</returns>
    public static float Normalize(float value, float start, float end)
    {
        return Raymath.Normalize(value, start, end);
    }

    /// <summary>
    /// Remap input value within input range to output range
    /// </summary>
    /// <param name="value">Value to remap</param>
    /// <param name="inputStart">Start of the input range</param>
    /// <param name="inputEnd">End of the input range</param>
    /// <param name="outputStart">Start of the output range</param>
    /// <param name="outputEnd">End of the output range</param>
    /// <returns>The remapped value</returns>
    public static float Remap(float value, float inputStart, float inputEnd, float outputStart, float outputEnd)
    {
        return Raymath.Remap(value, inputStart, inputEnd, outputStart, outputEnd);
    }

    /// <summary>
    /// Wrap input value within a specified range
    /// </summary>
    /// <param name="value">Value to wrap</param>
    /// <param name="min">Minimum value</param>
    /// <param name="max">Maximum value</param>
    /// <returns>The wrapped value</returns>
    public static float Wrap(float value, float min, float max)
    {
        return Raymath.Wrap(value, min, max);
    }

    /// <summary>
    /// Check whether two given floats are almost equal
    /// </summary>
    /// <param name="x">First float</param>
    /// <param name="y">Second float</param>
    /// <returns>True if the floats are almost equal, false otherwise</returns>
    public static int FloatEquals(float x, float y)
    {
        return Raymath.FloatEquals(x, y);
    }

    /// <summary>
    /// Get (evaluate) spline point: Linear
    /// </summary>
    /// <param name="startPos">Start position</param>
    /// <param name="endPos">End position</param>
    /// <param name="t">Time parameter</param>
    /// <returns>The spline point</returns>
    public static Vector2 GetSplinePointLinear(Vector2 startPos, Vector2 endPos, float t)
    {
        return Raylib.GetSplinePointLinear(startPos, endPos, t);
    }

    /// <summary>
    /// Get (evaluate) spline point: B-Spline
    /// </summary>
    /// <param name="p1">Control point 1</param>
    /// <param name="p2">Control point 2</param>
    /// <param name="p3">Control point 3</param>
    /// <param name="p4">Control point 4</param>
    /// <param name="t">Time parameter</param>
    /// <returns>The spline point</returns>
    public static Vector2 GetSplinePointBasis(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, float t)
    {
        return Raylib.GetSplinePointBasis(p1, p2, p3, p4, t);
    }

    /// <summary>
    /// Get (evaluate) spline point: Catmull-Rom
    /// </summary>
    /// <param name="p1">Control point 1</param>
    /// <param name="p2">Control point 2</param>
    /// <param name="p3">Control point 3</param>
    /// <param name="p4">Control point 4</param>
    /// <param name="t">Time parameter</param>
    /// <returns>The spline point</returns>
    public static Vector2 GetSplinePointCatmullRom(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, float t)
    {
        return Raylib.GetSplinePointCatmullRom(p1, p2, p3, p4, t);
    }

    /// <summary>
    /// Get (evaluate) spline point: Quadratic Bezier
    /// </summary>
    /// <param name="p1">Start point</param>
    /// <param name="c2">Control point</param>
    /// <param name="p3">End point</param>
    /// <param name="t">Time parameter</param>
    /// <returns>The spline point</returns>
    public static Vector2 GetSplinePointBezierQuad(Vector2 p1, Vector2 c2, Vector2 p3, float t)
    {
        return Raylib.GetSplinePointBezierQuad(p1, c2, p3, t);
    }

    /// <summary>
    /// Get (evaluate) spline point: Cubic Bezier
    /// </summary>
    /// <param name="p1">Start point</param>
    /// <param name="c2">Control point 1</param>
    /// <param name="c3">Control point 2</param>
    /// <param name="p4">End point</param>
    /// <param name="t">Time parameter</param>
    /// <returns>The spline point</returns>
    public static Vector2 GetSplinePointBezierCubic(Vector2 p1, Vector2 c2, Vector2 c3, Vector2 p4, float t)
    {
        return Raylib.GetSplinePointBezierCubic(p1, c2, c3, p4, t);
    }

    /// <summary>
    /// Orthonormalize provided vectors Makes vectors normalized and orthogonal to each other Gram-Schmidt function implementation
    /// </summary>
    public static unsafe void Vector3OrthoNormalize(Vector3* vector1, Vector3* vector2)
    {
        Raymath.Vector3OrthoNormalize(vector1, vector2);
    }

    /// <summary>
    /// Get translation matrix
    /// </summary>
    public static Matrix4x4 MatrixTranslate(float x, float y, float z)
    {
        return Raymath.MatrixTranslate(x, y, z);
    }

    /// <summary>
    /// Create rotation matrix from axis and angle NOTE: Angle should be provided in radians
    /// </summary>
    public static Matrix4x4 MatrixRotate(Vector3 axis, float angle)
    {
        return Raymath.MatrixRotate(axis, angle);
    }

    /// <summary>
    /// Get xyz-rotation matrix NOTE: Angle must be provided in radians
    /// </summary>
    public static Matrix4x4 MatrixRotateXYZ(Vector3 angle)
    {
        return Raymath.MatrixRotateXYZ(angle);
    }

    /// <summary>
    /// Get zyx-rotation matrix NOTE: Angle must be provided in radians
    /// </summary>
    public static Matrix4x4 MatrixRotateZYX(Vector3 angle)
    {
        return Raymath.MatrixRotateZYX(angle);
    }

    /// <summary>
    /// Calculate quaternion based on the rotation from one vector to another
    /// </summary>
    public static Quaternion QuaternionFromVector3ToVector3(Vector3 from, Vector3 to)
    {
        return Raymath.QuaternionFromVector3ToVector3(from, to);
    }

    /// <summary>
    /// Get a quaternion for a given rotation matrix
    /// </summary>
    public static Quaternion QuaternionFromMatrix(Matrix4x4 matrix)
    {
        return Raymath.QuaternionFromMatrix(matrix);
    }

    /// <summary>
    /// Get rotation quaternion for an angle and axis NOTE: Angle must be provided in radians
    /// </summary>
    public static Quaternion QuaternionFromAxisAngle(Vector3 axis, float angle)
    {
        return Raymath.QuaternionFromAxisAngle(axis, angle);
    }

    /// <summary>
    /// Get the quaternion equivalent to Euler angles NOTE: Rotation order is ZYX
    /// </summary>
    public static Quaternion QuaternionFromEuler(float pitch, float yaw, float roll)
    {
        return Raymath.QuaternionFromEuler(pitch, yaw, roll);
    }
}
