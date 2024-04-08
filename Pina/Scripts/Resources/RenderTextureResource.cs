using Raylib_cs;

namespace Pina.Scripts.Resources;


public sealed class RenderTextureResource : Resource
{
    public RenderTexture2D renderTexture;

    public bool Ready
    {
        get
        {
            return Raylib.IsRenderTextureReady(renderTexture);
        }
    }

    /// <summary>
    /// Load texture for rendering (framebuffer)
    /// </summary>
    /// <param name="width">The width of render texture</param>
    /// <param name="height">The height of render texture</param>
    public RenderTextureResource Load(int width, int height)
    {
        if (Ready)
        {
            Raylib.UnloadRenderTexture(renderTexture);
        }

        renderTexture = Raylib.LoadRenderTexture(width, height);

        return this;
    }

    /// <summary>
    /// Unload render texture from GPU memory (VRAM)
    /// </summary>
    public override void Unload()
    {
        base.Unload();

        if (!Ready)
        {
            throw new Exception("Error: RenderTexture is not loaded yet");
        }

        Raylib.UnloadRenderTexture(renderTexture);
    }
}
