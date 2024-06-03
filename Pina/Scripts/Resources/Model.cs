using Raylib_cs;
using RaylibModel = Raylib_cs.Model;

namespace Pina.Scripts.Resources;


public class Model : Resource
{
    RaylibModel raylibModel;

    /// <summary>
    /// if a model is ready
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
    /// Unload render texture from GPU memory (VRAM)
    /// </summary>
    protected override void Unload()
    {
        if (!Ready)
        {
            throw new Exception("Error: RenderTexture is not loaded yet");
        }

        Raylib.UnloadModel(raylibModel);

        base.Unload();
    }

    protected override void Dispose(bool disposing)
    {
        Unload();
    }
}
