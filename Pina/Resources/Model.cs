using Raylib_cs;
using RaylibModel = Raylib_cs.Model;
using RaylibModelAnimation = Raylib_cs.ModelAnimation;

namespace Pina.Resources;


public sealed class Model : Resource
{
    RaylibModel raylibModel;

    /// <summary>
    /// Determine if the model is ready
    /// </summary>
    public bool Ready
    {
        get
        {
            return Raylib.IsModelReady(raylibModel);
        }
    }

    /// <summary>
    /// Load model from files (meshes and materials)
    /// </summary>
    public static Model Load(string fileName)
    {
        Model model = new Model();

        model.raylibModel = Raylib.LoadModel(fileName);

        return model;
    }

    /// <summary>
    /// Load model from generated mesh (default material)
    /// </summary>
    public static Model LoadFromMesh(Mesh mesh)
    {
        Model model = new Model();

        model.raylibModel = Raylib.LoadModelFromMesh(mesh.raylibMesh);

        return model;
    }

    /// <summary>
    /// Set material for a mesh
    /// </summary>
    public void SetMeshMaterial(int meshId, int materialId)
    {
        Raylib.SetModelMeshMaterial(ref raylibModel, meshId, materialId);
    }

    /// <summary>
    /// Update model animation pose
    /// </summary>
    public unsafe void UpdateAnimation(RaylibModelAnimation raylibModelAnimation, int frame)
    {
        Raylib.UpdateModelAnimation(raylibModel, raylibModelAnimation, frame);
    }

    /// <summary>
    /// Check model animation skeleton match
    /// </summary>
    public bool IsAnimationValid(RaylibModelAnimation raylibModelAnimation)
    {
        return Raylib.IsModelAnimationValid(raylibModel, raylibModelAnimation);
    }


    /// <summary>
    /// Unload render texture from GPU memory (VRAM)
    /// </summary>
    protected override void Unload()
    {
        if (!Ready)
        {
            throw new Exception("Error: Model is not loaded yet");
        }

        Raylib.UnloadModel(raylibModel);

        base.Unload();
    }

    protected override void Dispose(bool disposing)
    {
        Unload();
    }
}
