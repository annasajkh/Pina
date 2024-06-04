using Raylib_cs;
using System.Numerics;

namespace Pina.Scripts.Extensions;

public static class QuaternionExtensions
{
    /// <summary>
    /// Add quaternion and float value
    /// </summary>
    public static Quaternion AddValue(this Quaternion value, float add)
    {
        return Raymath.QuaternionAddValue(value, add);
    }

    /// <summary>
    /// Subtract quaternion and float value
    /// </summary>
    public static Quaternion SubtractValue(this Quaternion value, float subtract)
    {
        return Raymath.QuaternionSubtractValue(value, subtract);
    }

    /// <summary>
    /// Computes the length of a quaternion
    /// </summary>
    public static float Length(this Quaternion value)
    {
        return Raymath.QuaternionLength(value);
    }

    /// <summary>
    /// Invert provided quaternion
    /// </summary>
    public static Quaternion Invert(this Quaternion value)
    {
        return Raymath.QuaternionInvert(value);
    }

    /// <summary>
    /// Scale quaternion by float value
    /// </summary>
    public static Quaternion Scale(this Quaternion value, float scale)
    {
        return Raymath.QuaternionScale(value, scale);
    }

    /// <summary>
    /// Calculate slerp-optimized interpolation between two quaternions
    /// </summary>
    public static Quaternion Nlerp(this Quaternion quaternion, Quaternion other, float amount)
    {
        return Raymath.QuaternionNlerp(quaternion, other, amount);
    }

    /// <summary>
    /// Get a matrix for a given quaternion
    /// </summary>
    public static Matrix4x4 ToMatrix(this Quaternion quaternion)
    {
        return Raymath.QuaternionToMatrix(quaternion);
    }

    /// <summary>
    /// Get the rotation angle and axis for a given quaternion
    /// </summary>
    public static unsafe void ToAxisAngle(this Quaternion quaternion, Vector3* outAxis, float* outAngle)
    {
        Raymath.QuaternionToAxisAngle(quaternion, outAxis, outAngle);
    }

    /// <summary>
    /// Get the Euler angles equivalent to quaternion (roll, pitch, yaw) NOTE: Angles are returned in a Vector3 struct in radians
    /// </summary>
    public static Vector3 ToEuler(this Quaternion quaternion)
    {
        return Raymath.QuaternionToEuler(quaternion);
    }

    /// <summary>
    /// Transform a quaternion given a transformation matrix
    /// </summary>
    public static Quaternion Transform(this Quaternion quaternion, Matrix4x4 matrix)
    {
        return Raymath.QuaternionTransform(quaternion, matrix);
    }
}
