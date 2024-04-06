using Raylib_cs;

namespace Pina.Scripts.Resources;


public sealed class RenderTextureResource : Resource
{
    public RenderTexture2D RenderTexture { get; private set; }

    public bool Ready
    {
        get
        {
            return Raylib.IsRenderTextureReady(RenderTexture);
        }
    }

    /// <summary>
    /// Load texture for rendering (framebuffer)
    /// </summary>
    /// <param name="width">The width of render texture</param>
    /// <param name="height">The height of render texture</param>
    public void Load(int width, int height)
    {
        RenderTexture = Raylib.LoadRenderTexture(width, height);
    }

    public override void Unload()
    {
        base.Unload();

        Raylib.UnloadRenderTexture(RenderTexture);
    }
}
