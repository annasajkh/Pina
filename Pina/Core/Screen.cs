using Raylib_cs;
using System.Numerics;

namespace Pina.Core;

public static class Screen
{
    /// <summary>
    /// Get current screen width
    /// </summary>
    public static int Width
    {
        get
        {
            return Raylib.GetScreenWidth();
        }
    }

    /// <summary>
    /// Get current screen height
    /// </summary>
    public static int Height
    {
        get
        {
            return Raylib.GetScreenHeight();
        }
    }


    /// <summary>
    /// Is cursor on the screen
    /// </summary>
    public static bool CursorOnScreen
    {
        get
        {
            return Raylib.IsCursorOnScreen();
        }
    }


    /// <summary>
    /// Get a ray trace from mouse position
    /// </summary>
    /// <param name="mousePosition">The mouse position</param>
    /// <param name="camera">The camera</param>
    /// <returns>The ray trace from the mouse position</returns>
    public static Ray GetMouseRay(Vector2 mousePosition, Camera3D camera)
    {
        return Raylib.GetMouseRay(mousePosition, camera);
    }

    /// <summary>
    /// Get the screen space position for a 3D world space position
    /// </summary>
    /// <param name="position">The world space position</param>
    /// <param name="camera">The camera</param>
    /// <returns>The screen space position</returns>
    public static Vector2 GetWorldToScreen(Vector3 position, Camera3D camera)
    {
        return Raylib.GetWorldToScreen(position, camera);
    }

    /// <summary>
    /// Get the world space position for a 2D camera screen space position
    /// </summary>
    /// <param name="position">The screen space position</param>
    /// <param name="camera">The 2D camera</param>
    /// <returns>The world space position</returns>
    public static Vector2 GetScreenToWorld2D(Vector2 position, Camera2D camera)
    {
        return Raylib.GetScreenToWorld2D(position, camera);
    }

    /// <summary>
    /// Get screen space position for a 3D world space position
    /// </summary>
    /// <param name="position">The world space position</param>
    /// <param name="camera">The camera</param>
    /// <param name="width">The width of the screen</param>
    /// <param name="height">The height of the screen</param>
    /// <returns>The screen space position</returns>
    public static Vector2 GetWorldToScreenEx(Vector3 position, Camera3D camera, int width, int height)
    {
        return Raylib.GetWorldToScreenEx(position, camera, width, height);
    }

    /// <summary>
    /// Get the screen space position for a 2D camera world space position
    /// </summary>
    /// <param name="position">The world space position</param>
    /// <param name="camera">The 2D camera</param>
    /// <returns>The screen space position</returns>
    public static Vector2 GetWorldToScreen2D(Vector2 position, Camera2D camera)
    {
        return Raylib.GetWorldToScreen2D(position, camera);
    }
}