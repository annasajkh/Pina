using Raylib_cs;

namespace Pina.Scripts.Resources;


public sealed class TextureResource : Resource
{
    private Texture2D texture;
    
    /// <summary>
    /// The raylib texture
    /// </summary>
    public Texture2D Texture 
    { 
        get
        {
            return texture;
        }

        private set
        {
            texture = value;
        }
    }

    /// <summary>
    /// determine if the texture is ready
    /// </summary>
    public bool Ready
    {
        get
        {
            return Raylib.IsTextureReady(Texture);
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
            textureFilter = value;
            Raylib.SetTextureFilter(Texture, textureFilter);
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
            textureWrap = value;
            Raylib.SetTextureWrap(Texture, textureWrap);
        }
    }

    /// <summary>
    /// Load texture from file into GPU memory (VRAM)
    /// </summary>
    /// <param name="path">The path to the texture</param>
    /// <param name="textureFilter">The texture filter</param>
    /// <param name="textureWrap">The texture wrap mode</param>
    public void Load(string path, TextureFilter textureFilter = TextureFilter.Bilinear, TextureWrap textureWrap = TextureWrap.Clamp)
    {
        Texture = Raylib.LoadTexture(path);

        TextureFilter = textureFilter;
        TextureWrap = textureWrap;
    }

    /// <summary>
    /// Load texture from image data
    /// </summary>
    /// <param name="image">The image</param>
    public void LoadFromImage(Image image, TextureFilter textureFilter = TextureFilter.Bilinear, TextureWrap textureWrap = TextureWrap.Clamp)
    {
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
        Raylib.UpdateTexture(Texture, pixels);
    }

    /// <summary>
    /// Update GPU texture rectangle with new data
    /// </summary>
    /// <param name="rectangle">The texture rectangle</param>
    /// <param name="pixels">The pixel data</param>
    public void UpdateTextureRec(Rectangle rectangle, byte[] pixels)
    {
        Raylib.UpdateTextureRec(texture, rectangle, pixels);
    }

    /// <summary>
    /// Generate GPU mipmaps for a texture
    /// </summary>
    public void GenMipmap()
    {
        Raylib.GenTextureMipmaps(ref texture);
    }

    /// <summary>
    /// Unload texture from GPU memory (VRAM)
    /// </summary>
    public override void Unload()
    {
        base.Unload();

        Raylib.UnloadTexture(Texture);
    }
}