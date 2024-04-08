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
    /// Check collision between two rectangles
    /// </summary>
    /// <param name="rec1">First rectangle</param>
    /// <param name="rec2">Second rectangle</param>
    /// <returns>True if collision detected, false otherwise</returns>
    public static bool CheckCollisionRecs(Rectangle rec1, Rectangle rec2)
    {
        return Raylib.CheckCollisionRecs(rec1, rec2);
    }

    /// <summary>
    /// Check collision between two circles
    /// </summary>
    /// <param name="center1">Center of the first circle</param>
    /// <param name="radius1">Radius of the first circle</param>
    /// <param name="center2">Center of the second circle</param>
    /// <param name="radius2">Radius of the second circle</param>
    /// <returns>True if collision detected, false otherwise</returns>
    public static bool CheckCollisionCircles(Vector2 center1, float radius1, Vector2 center2, float radius2)
    {
        return Raylib.CheckCollisionCircles(center1, radius1, center2, radius2);
    }

    /// <summary>
    /// Check collision between circle and rectangle
    /// </summary>
    /// <param name="center">Center of the circle</param>
    /// <param name="radius">Radius of the circle</param>
    /// <param name="rec">Rectangle</param>
    /// <returns>True if collision detected, false otherwise</returns>
    public static bool CheckCollisionCircleRec(Vector2 center, float radius, Rectangle rec)
    {
        return Raylib.CheckCollisionCircleRec(center, radius, rec);
    }

    /// <summary>
    /// Check if point is inside rectangle
    /// </summary>
    /// <param name="point">Point to check</param>
    /// <param name="rec">Rectangle</param>
    /// <returns>True if point is inside rectangle, false otherwise</returns>
    public static bool CheckCollisionPointRec(Vector2 point, Rectangle rec)
    {
        return Raylib.CheckCollisionPointRec(point, rec);
    }

    /// <summary>
    /// Check if point is inside circle
    /// </summary>
    /// <param name="point">Point to check</param>
    /// <param name="center">Center of the circle</param>
    /// <param name="radius">Radius of the circle</param>
    /// <returns>True if point is inside circle, false otherwise</returns>
    public static bool CheckCollisionPointCircle(Vector2 point, Vector2 center, float radius)
    {
        return Raylib.CheckCollisionPointCircle(point, center, radius);
    }

    /// <summary>
    /// Check if point is inside a triangle
    /// </summary>
    /// <param name="point">Point to check</param>
    /// <param name="p1">First vertex of the triangle</param>
    /// <param name="p2">Second vertex of the triangle</param>
    /// <param name="p3">Third vertex of the triangle</param>
    /// <returns>True if point is inside the triangle, false otherwise</returns>
    public static bool CheckCollisionPointTriangle(Vector2 point, Vector2 p1, Vector2 p2, Vector2 p3)
    {
        return Raylib.CheckCollisionPointTriangle(point, p1, p2, p3);
    }

    /// <summary>
    /// Check if point is within a polygon described by array of vertices
    /// </summary>
    /// <param name="point">Point to check</param>
    /// <param name="points">Array of vertices of the polygon</param>
    /// <param name="pointCount">Number of vertices in the polygon</param>
    /// <returns>True if point is inside the polygon, false otherwise</returns>
    public unsafe static bool CheckCollisionPointPoly(Vector2 point, Vector2* points, int pointCount)
    {
        return Raylib.CheckCollisionPointPoly(point, points, pointCount);
    }

    /// <summary>
    /// Check the collision between two lines defined by two points each
    /// </summary>
    /// <param name="startPos1">Start position of the first line</param>
    /// <param name="endPos1">End position of the first line</param>
    /// <param name="startPos2">Start position of the second line</param>
    /// <param name="endPos2">End position of the second line</param>
    /// <param name="collisionPoint">Output parameter for the collision point</param>
    /// <returns>True if collision detected, false otherwise</returns>
    public unsafe static bool CheckCollisionLines(Vector2 startPos1, Vector2 endPos1, Vector2 startPos2, Vector2 endPos2, ref Vector2 collisionPoint)
    {
        return Raylib.CheckCollisionLines(startPos1, endPos1, startPos2, endPos2, ref collisionPoint);
    }

    /// <summary>
    /// Check if point belongs to line created between two points [p1] and [p2] with defined margin in pixels [threshold]
    /// </summary>
    /// <param name="point">Point to check</param>
    /// <param name="p1">First point of the line</param>
    /// <param name="p2">Second point of the line</param>
    /// <param name="threshold">Threshold in pixels</param>
    /// <returns>True if the point belongs to the line, false otherwise</returns>
    public static bool CheckCollisionPointLine(Vector2 point, Vector2 p1, Vector2 p2, int threshold)
    {
        return Raylib.CheckCollisionPointLine(point, p1, p2, threshold);
    }

    /// <summary>
    /// Get collision rectangle for two rectangles collision
    /// </summary>
    /// <param name="rec1">First rectangle</param>
    /// <param name="rec2">Second rectangle</param>
    /// <returns>The collision rectangle</returns>
    public static Rectangle GetCollisionRec(Rectangle rec1, Rectangle rec2)
    {
        return Raylib.GetCollisionRec(rec1, rec2);
    }
}
