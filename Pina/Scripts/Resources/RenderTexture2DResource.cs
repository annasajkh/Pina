using Raylib_cs;

namespace Pina.Scripts.Resources;


public sealed class RenderTexture2DResource : Resource
{
    private RenderTexture2D renderTexture2D;
    public RenderTexture2D RenderTexture2D
    {
        get
        {
            return renderTexture2D;
        }
        private set
        {
            renderTexture2D = value;
        }
    }

    public override bool Ready
    {
        get
        {
            return Raylib.IsRenderTextureReady(renderTexture2D);
        }
    }

    /// <summary>
    /// Load texture for rendering (framebuffer)
    /// </summary>
    /// <param name="width">The width of render texture</param>
    /// <param name="height">The height of render texture</param>
    public RenderTexture2DResource Load(int width, int height)
    {
        if (Ready)
        {
            Raylib.UnloadRenderTexture(renderTexture2D);
        }

        renderTexture2D = Raylib.LoadRenderTexture(width, height);

        return this;
    }

    /// <summary>
    /// Unload render texture from GPU memory (VRAM)
    /// </summary>
    public override void Unload()
    {
        if (!Ready)
        {
            throw new Exception("Error: RenderTexture is not loaded yet");
        }

        Raylib.UnloadRenderTexture(renderTexture2D);

        base.Unload();
    }
}
