
using Raylib_cs;
using System.Numerics;

namespace Pina.Scripts.Core.Components;

using Camera2DRaylib = Raylib_cs.Camera2D;

public class Camera2D
{
    private Camera2DRaylib camera;

    /// <summary>
    /// Camera offset (displacement from target)
    /// </summary>
    public Vector2 Offset
    {
        get
        {
            return camera.Offset;
        }

        set
        {
            camera.Offset = value;
        }
    }

    /// <summary>
    /// Camera target (rotation and zoom origin)
    /// </summary>
    public Vector2 Target
    {
        get
        {
            return camera.Offset;
        }

        set
        {
            camera.Offset = value;
        }
    }

    /// <summary>
    ///  Camera rotation in degrees
    /// </summary>
    public float Rotation
    {
        get
        {
            return camera.Rotation;
        }

        set
        {
            camera.Rotation = value;
        }
    }

    public float Zoom
    {
        get
        {
            return camera.Zoom;
        }

        set
        {
            camera.Zoom = value;
        }
    }

    /// <summary>
    /// Camera zoom (scaling), should be 1.0f by default
    /// </summary>

    public Camera2D(Vector2 offset, Vector2 target, float rotation, float zoom)
    {
        camera = new(offset, target, rotation, zoom);
    }

    /// <summary>
    /// Get camera 2d transform matrix
    /// </summary>
    /// <param name="camera">The 2D camera</param>
    /// <returns>The camera 2D transform matrix</returns>
    public Matrix4x4 GetMatrix2D()
    {
        return Raylib.GetCameraMatrix2D(camera);
    }
}
