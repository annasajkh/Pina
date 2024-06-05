using Raylib_cs;
using System.Numerics;

namespace Pina.Extensions;

public static class Matrix4x4Extensions
{
    /// <summary>
    /// Compute matrix determinant
    /// </summary>
    public static float Determinant(this Matrix4x4 value)
    {
        return Raymath.MatrixDeterminant(value);
    }

    /// <summary>
    /// Get the trace of the matrix (sum of the values along the diagonal)
    /// </summary>
    public static float Trace(this Matrix4x4 value)
    {
        return Raymath.MatrixTrace(value);
    }

    /// <summary>
    /// Get float array of matrix data
    /// </summary>
    public static Float16 ToFloatV(this Matrix4x4 value)
    {
        return Raymath.MatrixToFloatV(value);
    }
}
