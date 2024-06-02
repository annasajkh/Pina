using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace Pina.Scripts.Core.Types;

public struct Vector2i : IEquatable<Vector2i>, IFormattable
{
    public int X;
    public int Y;

    /// <summary>Returns a vector whose 2 elements are equal to zero.</summary>
    /// <value>A vector whose two elements are equal to zero (that is, it returns the vector <c>(0,0)</c>.</value>
    public static Vector2i Zero
    {
        get => default;
    }

    /// <summary>Gets a vector whose 2 elements are equal to one.</summary>
    /// <value>A vector whose two elements are equal to one (that is, it returns the vector <c>(1,1)</c>.</value>
    public static Vector2i One
    {
        get => new Vector2i(1, 0);
    }

    /// <summary>Gets the vector (1,0).</summary>
    /// <value>The vector <c>(1,0)</c>.</value>
    public static Vector2i UnitX
    {
        get => new Vector2i(1, 0);
    }

    /// <summary>Gets the vector (0,1).</summary>
    /// <value>The vector <c>(0,1)</c>.</value>
    public static Vector2i UnitY
    {
        get => new Vector2i(0, 1);
    }

    public Vector2i(int x, int y)
    {
        X = x;
        Y = y;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector2i operator +(Vector2i left, Vector2i right)
    {
        return new Vector2i(left.X + right.X, left.Y + right.Y);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector2i operator -(Vector2i left, Vector2i right)
    {
        return new Vector2i(left.X - right.X, left.Y - right.Y);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector2i operator *(Vector2i left, Vector2i right)
    {
        return new Vector2i(left.X * right.X, left.Y * right.Y);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector2i operator /(Vector2i left, Vector2i right)
    {
        return new Vector2i(left.X / right.X, left.Y / right.Y);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector2i operator %(Vector2i left, Vector2i right)
    {
        return new Vector2i(left.X % right.X, left.Y % right.Y);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector2 operator +(Vector2i left, float right)
    {
        return new Vector2(left.X + right, left.Y + right);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector2 operator -(Vector2i left, float right)
    {
        return new Vector2(left.X - right, left.Y - right);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector2 operator *(Vector2i left, float right)
    {
        return new Vector2(left.X * right, left.Y * right);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector2 operator /(Vector2i left, float right)
    {
        return new Vector2(left.X / right, left.Y / right);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector2 operator %(Vector2i left, float right)
    {
        return new Vector2(left.X % right, left.Y % right);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(Vector2i left, Vector2i right)
    {
        return left.X == right.X && left.Y == right.Y;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(Vector2i left, Vector2i right)
    {
        return !(left == right);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override readonly bool Equals([NotNullWhen(true)] object? obj)
    {
        return obj is Vector2i other && Equals(other);
    }

    public readonly bool Equals(Vector2i other)
    {
        return this == other;
    }

    public override readonly int GetHashCode()
    {
        return HashCode.Combine(X, Y);
    }

    public override readonly string ToString()
    {
        return ToString("G", CultureInfo.CurrentCulture);
    }

    public readonly string ToString(string? format)
    {
        return ToString(format, CultureInfo.CurrentCulture);
    }

    public readonly string ToString(string? format, IFormatProvider? formatProvider)
    {
        StringBuilder sb = new StringBuilder();

        string separator = NumberFormatInfo.GetInstance(formatProvider).NumberGroupSeparator;

        sb.Append('<');
        sb.Append(X.ToString(format, formatProvider));
        sb.Append(separator);
        sb.Append(' ');
        sb.Append(Y.ToString(format, formatProvider));
        sb.Append('>');

        return sb.ToString();
    }
}
