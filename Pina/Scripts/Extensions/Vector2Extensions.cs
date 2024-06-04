using Raylib_cs;
using System.Numerics;

namespace Pina.Scripts.Extensions;

public static class Vector2Extensions
{
    /// <summary>
    /// Rotate vector by angle
    /// </summary>
    public static Vector2 Rotate(this Vector2 value, float angle)
    {
        return Raymath.Vector2Rotate(value, angle);
    }

    /// <summary>
    /// Move Vector towards target
    /// </summary>
    public static Vector2 MoveTowards(this Vector2 value, Vector2 target, float maxDistance)
    {
        return Raymath.Vector2MoveTowards(value, target, maxDistance);
    }

    /// <summary>
    /// Invert the given vector
    /// </summary>
    public static Vector2 Invert(this Vector2 value)
    {
        return Raymath.Vector2Invert(value);
    }

    /// <summary>
    /// Clamp the magnitude of the vector between two min and max values
    /// </summary>
    public static Vector2 ClampValue(this Vector2 value, float min, float max)
    {
        return Raymath.Vector2ClampValue(value, min, max);
    }

    /// <summary>
    /// Calculate angle from two vectors
    /// </summary>
    public static float Angle(this Vector2 value, Vector2 target)
    {
        return Raymath.Vector2Angle(value, target);
    }
}