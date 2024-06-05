using Raylib_cs;
using System.Numerics;

namespace Pina.Core;

public static class Collision
{
    /// <summary>
    /// Check collision between two rectangles
    /// </summary>
    /// <param name="rec1">First rectangle</param>
    /// <param name="rec2">Second rectangle</param>
    /// <returns>True if collision detected, false otherwise</returns>
    public static bool CheckRecs(Rectangle rec1, Rectangle rec2)
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
    public static bool CheckCircles(Vector2 center1, float radius1, Vector2 center2, float radius2)
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
    public static bool CheckCircleRec(Vector2 center, float radius, Rectangle rec)
    {
        return Raylib.CheckCollisionCircleRec(center, radius, rec);
    }

    /// <summary>
    /// Check if point is inside rectangle
    /// </summary>
    /// <param name="point">Point to check</param>
    /// <param name="rec">Rectangle</param>
    /// <returns>True if point is inside rectangle, false otherwise</returns>
    public static bool CheckPointRec(Vector2 point, Rectangle rec)
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
    public static bool CheckPointCircle(Vector2 point, Vector2 center, float radius)
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
    public static bool CheckPointTriangle(Vector2 point, Vector2 p1, Vector2 p2, Vector2 p3)
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
    public unsafe static bool CheckPointPoly(Vector2 point, Vector2* points, int pointCount)
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
    public unsafe static bool CheckLines(Vector2 startPos1, Vector2 endPos1, Vector2 startPos2, Vector2 endPos2, ref Vector2 collisionPoint)
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
    public static bool CheckPointLine(Vector2 point, Vector2 p1, Vector2 p2, int threshold)
    {
        return Raylib.CheckCollisionPointLine(point, p1, p2, threshold);
    }

    /// <summary>
    /// Get collision rectangle for two rectangles collision
    /// </summary>
    /// <param name="rec1">First rectangle</param>
    /// <param name="rec2">Second rectangle</param>
    /// <returns>The collision rectangle</returns>
    public static Rectangle GetRec(Rectangle rec1, Rectangle rec2)
    {
        return Raylib.GetCollisionRec(rec1, rec2);
    }

    /// <summary>
    /// Check collision between two spheres
    /// </summary>
    /// <param name="center1">First sphere center</param>
    /// <param name="radius1">First sphere radius</param>
    /// <param name="center2">Second sphere center</param>
    /// <param name="radius2">Second sphere radius</param>
    /// <returns>True if both are colliding, false otherwise</returns>
    public static bool CheckSpheres(Vector3 center1, float radius1, Vector3 center2, float radius2)
    {
        return Raylib.CheckCollisionSpheres(center1, radius1, center2, radius2);
    }

    /// <summary>
    /// Check collision between two bounding boxes
    /// </summary>
    /// <param name="box1">The first bounding box</param>
    /// <param name="box2">The second bounding box</param>
    /// <returns>True if both are colliding, false otherwise</returns>
    public static bool CheckBoxes(BoundingBox box1, BoundingBox box2)
    {
        return Raylib.CheckCollisionBoxes(box1, box2);
    }

    /// <summary>
    /// Check collision between box and sphere
    /// </summary>
    /// <param name="box">The bounding box</param>
    /// <param name="center">the sphere center</param>
    /// <param name="radius">the sphere radius</param>
    /// <returns>True if both are colliding, false otherwise</returns>
    public static bool CheckBoxSphere(BoundingBox box, Vector3 center, float radius)
    {
        return Raylib.CheckCollisionBoxSphere(box, center, radius);
    }

    /// <summary>
    /// Get collision info between ray and sphere
    /// </summary>
    /// <param name="ray">The ray</param>
    /// <param name="center">the sphere center</param>
    /// <param name="radius">the sphere radius</param>
    public static RayCollision GetRaySphere(Ray ray, Vector3 center, float radius)
    {
        return Raylib.GetRayCollisionSphere(ray, center, radius);
    }

    /// <summary>
    /// Get collision info between ray and box
    /// </summary>
    /// <param name="ray">The ray</param>
    /// <param name="box">The bounding box</param>
    public static RayCollision GetRayBox(Ray ray, BoundingBox box)
    {
        return Raylib.GetRayCollisionBox(ray, box);
    }

    /// <summary>
    /// Get collision info between ray and mesh
    /// </summary>
    /// <param name="ray">The ray</param>
    /// <param name="mesh"></param>
    /// <param name="transform">The transformation matrix</param>
    public static RayCollision GetRayMesh(Ray ray, Mesh mesh, Matrix4x4 transform)
    {
        return Raylib.GetRayCollisionMesh(ray, mesh, transform);
    }

    /// <summary>
    /// Get collision info between ray and triangle
    /// </summary>
    /// <param name="ray">The ray</param>
    /// <param name="p1">The first point of the triangle</param>
    /// <param name="p2">The second point of the triangle</param>
    /// <param name="p3">The third point of the triangle</param>
    public static RayCollision GetRayTriangle(Ray ray, Vector3 p1, Vector3 p2, Vector3 p3)
    {
        return Raylib.GetRayCollisionTriangle(ray, p1, p2, p3);
    }

    /// <summary>
    /// Get collision info between ray and quad
    /// </summary>
    /// <param name="ray">The ray</param>
    /// <param name="p1">The first point of the quad</param>
    /// <param name="p2">The second point of the quad</param>
    /// <param name="p3">The third point of the quad</param>
    /// <param name="p4">The fourth point of the quad</param>
    /// <returns></returns>
    public static RayCollision GetRayQuad(Ray ray, Vector3 p1, Vector3 p2, Vector3 p3, Vector3 p4)
    {
        return Raylib.GetRayCollisionQuad(ray, p1, p2, p3, p4);
    }
}
