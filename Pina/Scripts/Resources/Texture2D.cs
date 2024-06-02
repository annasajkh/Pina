using Raylib_cs;
using RaylibTexture2D = Raylib_cs.Texture2D;
namespace Pina.Scripts.Resources;


public sealed class Texture2D : Resource
{
    public RaylibTexture2D raylibTexture2D;

    /// <summary>
    /// determine if the texture is ready
    /// </summary>
    public override bool Ready
    {
        get
        {
            return Raylib.IsTextureReady(raylibTexture2D);
        }
    }

    /// <summary>
    /// Get the source rectangle
    /// </summary>
    public Rectangle SourceRectangle
    {
        get
        {
            return new Rectangle(0, 0, raylibTexture2D.Width, raylibTexture2D.Height);
        }
    }

    private TextureFilter textureFilter;

    /// <summary>
    /// texture scaling filter mode
    /// </summary>
    public TextureFilter TextureFilter
    {
        get
        {
            return textureFilter;
        }

        set
        {
            if (!Ready)
            {
                throw new Exception("Error: Texture is not loaded yet");
            }

            textureFilter = value;
            Raylib.SetTextureFilter(raylibTexture2D, textureFilter);
        }
    }

    private TextureWrap textureWrap;

    /// <summary>
    /// texture wrapping mode
    /// </summary>
    public TextureWrap TextureWrap
    {
        get
        {
            return textureWrap;
        }

        set
        {
            if (!Ready)
            {
                throw new Exception("Error: Texture is not loaded yet");
            }

            textureWrap = value;
            Raylib.SetTextureWrap(raylibTexture2D, textureWrap);
        }
    }

    /// <summary>
    /// Load texture from file into GPU memory (VRAM)
    /// </summary>
    /// <param name="fileName">The filename of the texture</param>
    /// <param name="textureFilter">The texture filter</param>
    /// <param name="textureWrap">The texture wrap mode</param>
    public static Texture2D Load(string fileName, TextureFilter textureFilter = TextureFilter.Bilinear, TextureWrap textureWrap = TextureWrap.Clamp)
    {
        Texture2D texture2D = new Texture2D();

        texture2D.raylibTexture2D = Raylib.LoadTexture(fileName);

        texture2D.TextureFilter = textureFilter;
        texture2D.TextureWrap = textureWrap;

        return texture2D;
    }

    /// <summary>
    /// Load texture from image data
    /// </summary>
    /// <param name="image">The image</param>
    public static Texture2D LoadFromImage(Raylib_cs.Image image, TextureFilter textureFilter = TextureFilter.Bilinear, TextureWrap textureWrap = TextureWrap.Clamp)
    {
        Texture2D texture2D = new Texture2D();

        texture2D.raylibTexture2D = Raylib.LoadTextureFromImage(image);

        texture2D.TextureFilter = textureFilter;
        texture2D.TextureWrap = textureWrap;

        return texture2D;
    }

    /// <summary>
    /// Update GPU texture with new data
    /// </summary>
    /// <param name="pixels">The pixel data</param>
    public void Update(byte[] pixels)
    {
        if (!Ready)
        {
            throw new Exception("Error: Texture is not loaded yet");
        }

        Raylib.UpdateTexture(raylibTexture2D, pixels);
    }

    /// <summary>
    /// Update GPU texture rectangle with new data
    /// </summary>
    /// <param name="rectangle">The texture rectangle</param>
    /// <param name="pixels">The pixel data</param>
    public void UpdateTextureRec(Rectangle rectangle, byte[] pixels)
    {
        if (!Ready)
        {
            throw new Exception("Error: Texture is not loaded yet");
        }

        Raylib.UpdateTextureRec(raylibTexture2D, rectangle, pixels);
    }

    /// <summary>
    /// Generate GPU mipmaps for a texture
    /// </summary>
    public void GenMipmap()
    {
        if (!Ready)
        {
            throw new Exception("Error: Texture is not loaded yet");
        }

        var textureTemp = raylibTexture2D;
        Raylib.GenTextureMipmaps(ref textureTemp);
    }

    /// <summary>
    /// Unload texture from GPU memory (VRAM)
    /// </summary>
    protected override void Unload()
    {
        if (!Ready)
        {
            throw new Exception("Error: Texture is not loaded yet");
        }

        Raylib.UnloadTexture(raylibTexture2D);

        base.Unload();
    }

    protected override void Dispose(bool disposing)
    {
        Unload();
    }
}