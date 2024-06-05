using Raylib_cs;
using RaylibRenderTexture2D = Raylib_cs.RenderTexture2D;

namespace Pina.Resources;


public sealed class RenderTexture2D : Resource
{
    public RaylibRenderTexture2D raylibRenderTexture2D;

    /// <summary>
    /// Determine if the render texture 2d is ready
    /// </summary>
    public bool Ready
    {
        get
        {
            return Raylib.IsRenderTextureReady(raylibRenderTexture2D);
        }
    }

    /// <summary>
    /// Get the source rectangle
    /// </summary>
    public Rectangle SourceRectangle
    {
        get
        {
            return new Rectangle(0, 0, raylibRenderTexture2D.Texture.Width, raylibRenderTexture2D.Texture.Height);
        }
    }

    /// <summary>
    /// Load texture for rendering (framebuffer)
    /// </summary>
    /// <param name="width">The width of render texture</param>
    /// <param name="height">The height of render texture</param>
    public static RenderTexture2D Load(int width, int height)
    {
        RenderTexture2D renderTexture2D = new RenderTexture2D();

        renderTexture2D.raylibRenderTexture2D = Raylib.LoadRenderTexture(width, height);

        return renderTexture2D;
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

        Raylib.UnloadRenderTexture(raylibRenderTexture2D);

        base.Unload();
    }

    protected override void Dispose(bool disposing)
    {
        Unload();
    }
}
