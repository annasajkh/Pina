using Raylib_cs;

namespace Pina.Scripts.Resources;


public sealed class TextureResource : Resource
{
    /// <summary>
    /// The raylib texture
    /// </summary>
    public Texture2D? Texture { get; private set; }

    /// <summary>
    /// determine if the texture is ready
    /// </summary>
    public bool Ready
    {
        get
        {
            if (Texture == null)
            {
                throw new Exception("Error: Texture is not loaded yet");
            }

            return Raylib.IsTextureReady((Texture2D)Texture);
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
            if (Texture == null)
            {
                throw new Exception("Error: Texture is not loaded yet");
            }

            textureFilter = value;
            Raylib.SetTextureFilter((Texture2D)Texture, textureFilter);
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
            if (Texture == null)
            {
                throw new Exception("Error: Texture is not loaded yet");
            }

            textureWrap = value;
            Raylib.SetTextureWrap((Texture2D)Texture, textureWrap);
        }
    }

    /// <summary>
    /// Load texture from file into GPU memory (VRAM)
    /// </summary>
    /// <param name="fileName">The filename of the texture</param>
    /// <param name="textureFilter">The texture filter</param>
    /// <param name="textureWrap">The texture wrap mode</param>
    public void Load(string fileName, TextureFilter textureFilter = TextureFilter.Bilinear, TextureWrap textureWrap = TextureWrap.Clamp)
    {
        if (Texture != null)
        {
            Raylib.UnloadTexture((Texture2D)Texture);
        }

        Texture = Raylib.LoadTexture(fileName);

        TextureFilter = textureFilter;
        TextureWrap = textureWrap;
    }

    /// <summary>
    /// Load texture from image data
    /// </summary>
    /// <param name="image">The image</param>
    public void LoadFromImage(Image image, TextureFilter textureFilter = TextureFilter.Bilinear, TextureWrap textureWrap = TextureWrap.Clamp)
    {
        if (Texture != null)
        {
            Raylib.UnloadTexture((Texture2D)Texture);
        }

        Texture = Raylib.LoadTextureFromImage(image);

        TextureFilter = textureFilter;
        TextureWrap = textureWrap;
    }

    /// <summary>
    /// Update GPU texture with new data
    /// </summary>
    /// <param name="pixels">The pixel data</param>
    public void Update(byte[] pixels)
    {
        if (Texture == null)
        {
            throw new Exception("Error: Texture is not loaded yet");
        }

        Raylib.UpdateTexture((Texture2D)Texture, pixels);
    }

    /// <summary>
    /// Update GPU texture rectangle with new data
    /// </summary>
    /// <param name="rectangle">The texture rectangle</param>
    /// <param name="pixels">The pixel data</param>
    public void UpdateTextureRec(Rectangle rectangle, byte[] pixels)
    {
        if (Texture == null)
        {
            throw new Exception("Error: Texture is not loaded yet");
        }

        Raylib.UpdateTextureRec((Texture2D)Texture, rectangle, pixels);
    }

    /// <summary>
    /// Generate GPU mipmaps for a texture
    /// </summary>
    public void GenMipmap()
    {
        if (Texture == null)
        {
            throw new Exception("Error: Texture is not loaded yet");
        }

        var textureTemp = (Texture2D)Texture;
        Raylib.GenTextureMipmaps(ref textureTemp);
    }

    /// <summary>
    /// Unload texture from GPU memory (VRAM)
    /// </summary>
    public override void Unload()
    {
        base.Unload();
        
        if (Texture == null)
        {
            throw new Exception("Error: Texture is not loaded yet");
        }

        Raylib.UnloadTexture((Texture2D)Texture);
    }
}