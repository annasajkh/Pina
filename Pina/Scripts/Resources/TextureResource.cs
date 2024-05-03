using Raylib_cs;

namespace Pina.Scripts.Resources;


public sealed class TextureResource : Resource
{
    private Texture2D texture2D;
    public Texture2D Texture2D
    {
        get => texture2D;
        private set => texture2D = value;
    }

    /// <summary>
    /// determine if the texture is ready
    /// </summary>
    public override bool Ready
    {
        get
        {
            return Raylib.IsTextureReady(texture2D);
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
            Raylib.SetTextureFilter(texture2D, textureFilter);
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
            Raylib.SetTextureWrap(texture2D, textureWrap);
        }
    }

    /// <summary>
    /// Load texture from file into GPU memory (VRAM)
    /// </summary>
    /// <param name="fileName">The filename of the texture</param>
    /// <param name="textureFilter">The texture filter</param>
    /// <param name="textureWrap">The texture wrap mode</param>
    public TextureResource Load(string fileName, TextureFilter textureFilter = TextureFilter.Bilinear, TextureWrap textureWrap = TextureWrap.Clamp)
    {
        if (Ready)
        {
            Raylib.UnloadTexture(texture2D);
        }

        texture2D = Raylib.LoadTexture(fileName);

        TextureFilter = textureFilter;
        TextureWrap = textureWrap;

        return this;
    }

    /// <summary>
    /// Load texture from image data
    /// </summary>
    /// <param name="image">The image</param>
    public TextureResource LoadFromImage(Image image, TextureFilter textureFilter = TextureFilter.Bilinear, TextureWrap textureWrap = TextureWrap.Clamp)
    {
        if (Ready)
        {
            Raylib.UnloadTexture(texture2D);
        }

        texture2D = Raylib.LoadTextureFromImage(image);

        TextureFilter = textureFilter;
        TextureWrap = textureWrap;

        return this;
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

        Raylib.UpdateTexture(texture2D, pixels);
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

        Raylib.UpdateTextureRec(texture2D, rectangle, pixels);
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

        var textureTemp = texture2D;
        Raylib.GenTextureMipmaps(ref textureTemp);
    }

    /// <summary>
    /// Unload texture from GPU memory (VRAM)
    /// </summary>
    public override void Unload()
    {
        
        if (!Ready)
        {
            throw new Exception("Error: Texture is not loaded yet");
        }

        Raylib.UnloadTexture(texture2D);

        base.Unload();
    }
}