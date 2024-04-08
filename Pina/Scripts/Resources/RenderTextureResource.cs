using Raylib_cs;

namespace Pina.Scripts.Resources;


public sealed class RenderTextureResource : Resource
{
    public RenderTexture2D? RenderTexture { get; private set; }

    public bool Ready
    {
        get
        {
            if (RenderTexture == null)
            {
                throw new Exception("Error: RenderTexture is not loaded yet");
            }

            return Raylib.IsRenderTextureReady((RenderTexture2D)RenderTexture);
        }
    }

    /// <summary>
    /// Load texture for rendering (framebuffer)
    /// </summary>
    /// <param name="width">The width of render texture</param>
    /// <param name="height">The height of render texture</param>
    public void Load(int width, int height)
    {
        if (RenderTexture != null)
        {
            Raylib.UnloadRenderTexture((RenderTexture2D)RenderTexture);
        }

        RenderTexture = Raylib.LoadRenderTexture(width, height);
    }

    /// <summary>
    /// Unload render texture from GPU memory (VRAM)
    /// </summary>
    public override void Unload()
    {
        base.Unload();

        if (RenderTexture == null)
        {
            throw new Exception("Error: RenderTexture is not loaded yet");
        }

        Raylib.UnloadRenderTexture((RenderTexture2D)RenderTexture);
    }
}
