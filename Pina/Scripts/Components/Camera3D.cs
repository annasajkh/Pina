using Raylib_cs;
using System.Numerics;

namespace Pina.Scripts.Components;

using Camera3DRaylib = Raylib_cs.Camera3D;

public sealed class Camera3D
{

    private Camera3DRaylib camera;

    public Camera3DRaylib Camera
    {
        get
        {
            return camera;
        }
    }

    /// <summary>
    /// The transform matrix (view matrix)
    /// </summary>
    public Matrix4x4 Matrix
    {
        get
        {
            return Raylib.GetCameraMatrix(camera);
        }
    }


    /// <summary>
    /// Camera position
    /// </summary>
    public Vector3 Position
    {
        get
        {
            return camera.Position;
        }

        set
        {
            camera.Position = value;
        }
    }

    /// <summary>
    /// Camera target it looks-at
    /// </summary>
    public Vector3 Target
    {
        get
        {
            return camera.Position;
        }

        set
        {
            camera.Target = value;
        }
    }

    /// <summary>
    /// Camera up vector (rotation over its axis)
    /// </summary>
    public Vector3 Up
    {
        get
        {
            return camera.Up;
        }

        set
        {
            camera.Up = value;
        }
    }

    /// <summary>
    /// Camera field-of-view apperture in Y (degrees) in perspective, used as near plane width in orthographic
    /// </summary>
    public float FovY
    {
        get
        {
            return camera.FovY;
        }

        set
        {
            camera.FovY = value;
        }
    }

    /// <summary>
    /// Camera type, defines projection type: CAMERA_PERSPECTIVE or CAMERA_ORTHOGRAPHIC
    /// </summary>
    public CameraProjection Projection
    {
        get
        {
            return camera.Projection;
        }

        set
        {
            camera.Projection = value;
        }
    }
}
